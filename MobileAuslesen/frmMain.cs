using MobileAuslesen.Controller.InstanzController;
using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Events;
using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Lade AnzeigenListe und überprüfe
            var anzeigenListe = StorageController.GetAnzeigeListeFromDrive();
            if (anzeigenListe != null) this.AnzeigeListe = anzeigenListe;

            //Filter nicht aktuelle anzeigen raus
            anzeigenListe = await AnzeigenController.CheckVerfuegbar(anzeigenListe);

            //füge AnzeigenListe der BindingSource hinzu
            bsAnzeigen.DataSource = AnzeigeListe;

            //verdrahte das MessageReceive Event 
            WebSocketEventPool.MessageReceive += OnMessageReceive;
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

                //Erstelle aus empfangenen daten eine Anzeige und überprüfe
                var anzeige = HtmlDocumentController.CreateAnzeige(e);
                if (anzeige == null) return;

                //Füge erstellte anzeige, der liste hinzu
                AnzeigeListe.Add(anzeige);

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

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
