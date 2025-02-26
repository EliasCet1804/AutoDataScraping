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

                switch (e.Art)
                {
                    case Core.EnumDefinition.MessageArt.None: break;
                    case Core.EnumDefinition.MessageArt.ConfigMessage: break;
                    case Core.EnumDefinition.MessageArt.AnzeigenMessage: AddNewAnzeige(e); break;
                }
            }
        }

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



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmNew frm = new frmNew())
            {
                frm.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (dataGridView1.SelectedRows.Count < 1) return;

            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0 || index >= AnzeigeListe.Count) return;

            AnzeigeListe.RemoveAt(index);

            bsAnzeigen.ResetBindings(false);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0 || index >= AnzeigeListe.Count) return;

            using (frmAnzeige frm = new frmAnzeige(AnzeigeListe[index]))
            {
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
