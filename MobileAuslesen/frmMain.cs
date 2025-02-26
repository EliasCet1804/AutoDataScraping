using MobileAuslesen.Controller.InstanzController;
using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Events;
using MobileAuslesen.Models;
using MobileAuslesen.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace MobileAuslesen
{
    public partial class frmMain : Form
    {
        #region Variablen
        private WebSocketController WebsocketController = new WebSocketController();
        private List<Anzeige> AnzeigeListe = new List<Anzeige>();
        #endregion

        #region Start
        public frmMain()
        {
            InitializeComponent();

            Application.Idle += OnLoaded;
        }

        private async void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            //Starte WebSockerServer
            this.WebsocketController.Start();

            //Lade gespeicherte Anzeigen
            var list = await AnzeigenController.LoadAnzeigen();
            if (list != null) this.AnzeigeListe = list;

            //füge AnzeigenListe der BindingSource hinzu
            bsAnzeigen.DataSource = this.AnzeigeListe;

            //verdrahte die CustomEvents
            VerdahteCustomEvents();
        }

        private void VerdahteCustomEvents()
        {
            WebSocketEventPool.MessageReceive += OnMessageReceive;
            EventPool.DeleteAnzeige += OnDeleteAnzeige;
        }

        #endregion

        #region Custom Events
        private void OnMessageReceive(object sender, WebSocketData e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnMessageReceive(sender, e)));
            } else
            {
                //Vorabüberprüfung
                if (e == null) return;

                //Überprüfe, um welche art es sich handelt und bearbeite die Message dann
                switch (e.Art)
                {
                    case Core.EnumDefinition.MessageArt.None: break;
                    case Core.EnumDefinition.MessageArt.ConfigMessage: OpenConfigEintragForm(e); break;
                    case Core.EnumDefinition.MessageArt.AnzeigenMessage: AddNewAnzeige(e); break;
                }
            }
        }

        /// <summary>
        /// Erstelle aus WebSocketData eine Neue Anzeige und füge diese der Oberfläche hinzu
        /// </summary>
        /// <param name="e"></param>
        private void AddNewAnzeige(WebSocketData e)
        {
            //Erstelle aus empfangenen daten eine Anzeige und überprüfe
            var anzeige = HtmlDocumentController.CreateAnzeige(e);
            if (anzeige == null) return;

            //Füge erstellte anzeige, der liste hinzu
            AnzeigeListe.Add(anzeige);

            //Update die Oberfläche
            this.Validate();
            bsAnzeigen.ResetBindings(false);
        }

        private void OnDeleteAnzeige(object sender, Anzeige e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDeleteAnzeige(sender, e)));
            } else
            {
                //Vorabüberprüfung
                if (e == null) return;

                //Entferne Anzeige aus Liste
                AnzeigeListe.Remove(e);

                //Update die Oberfläche
                this.Validate();
                bsAnzeigen.ResetBindings(false);

            }
        }

        #endregion

        #region Events
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Vorabüberprüfung
            if (this.AnzeigeListe == null) return;

            //Speicher die AnzeigenListe auf der Festplatte
            StorageController.SaveAnzeigenData(AnzeigeListe);

        }

        private void OpenConfigEintragForm(WebSocketData data)
        {
            using (frmSetConfigEintrag frm = new frmSetConfigEintrag(data))
            {
                frm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Öffne die Form zur erstellung eines neuen Eintrages
            using (frmNew frm = new frmNew())
            {
                frm.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0 || index >= AnzeigeListe.Count) return;

            //Lösche ausgewählte Anzeige
            AnzeigeListe.RemoveAt(index);

            //aktualisiere Oberfl#che 
            bsAnzeigen.ResetBindings(false);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0 || index >= AnzeigeListe.Count) return;

            //Öffne ausgewählte Anzeige
            using (frmAnzeige frm = new frmAnzeige(AnzeigeListe[index]))
            {
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
