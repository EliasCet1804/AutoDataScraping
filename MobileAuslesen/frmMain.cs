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

        private WebSocketController WebsocketController = new WebSocketController();
        private List<Anzeige> AnzeigeListe = new List<Anzeige>();

        public frmMain()
        {
            InitializeComponent();

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            //Starte WebSockerServer
            this.WebsocketController.Start();

            //Lade AnzeigenListe und überprüfe
            var anzeigenListe = StorageController.GetAnzeigeListeFromDrive();
            if (anzeigenListe != null) this.AnzeigeListe = anzeigenListe;

            //füge AnzeigenListe der BindingSource hinzu
            bsAnzeigen.DataSource = AnzeigeListe;

            //verdrahte das MessageReceive Event 
            WebSocketEventPool.MessageReceive += OnMessageReceive;
        }

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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Vorabüberprüfung
            if (this.AnzeigeListe == null) return;

            //Speicher die AnzeigenListe auf der Festplatte
            StorageController.SaveAnzeigenData(AnzeigeListe);

        }
    }
}
