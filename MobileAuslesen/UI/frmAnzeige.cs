using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Events;
using MobileAuslesen.Models;
using MobileAuslesen.UI.UserControls;
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

namespace MobileAuslesen.UI
{
    public partial class frmAnzeige : Form
    {
        private Anzeige Anzeige = null;

        internal frmAnzeige(Anzeige anzeige)
        {
            InitializeComponent();

            this.Anzeige = anzeige;

            this.Text = anzeige.Titel;

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetGrundLagenInformationen(), "Grundlagen"), 0, 0);
            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetSonstigeInformationen(), "Sonstige Informationen"), 1, 0);
            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetAnbieterInformationen(), "Anbieter Informationen"), 2, 0);
            //AddPictureBoxControl(this.Anzeige.Auto.Images);

            tableLayoutPanel1.Controls.Add(new ucTextControl(GetAusstatungsListBox(), "Ausstattung"), 0, 1);

            var x = new ucTextControl(GetBeschreibungsLabel(), "Beschreibung");
            tableLayoutPanel1.Controls.Add(x, 1, 1);
            tableLayoutPanel1.SetColumnSpan(x, 2);

        }

        private void AddPictureBoxControl(List<Bild> images)
        {
            ucImageBox ib = new ucImageBox();
            ib.AddPictures(images);

            tableLayoutPanel1.Controls.Add(ib, 2, 0);
        }

        private Control GetBeschreibungsLabel()
        {
            WebBrowser label = new WebBrowser();
            label.DocumentText = this.Anzeige.Beschreibung;
            label.Dock = DockStyle.Fill;
            return label;
        }

        private Control GetAusstatungsListBox()
        {
            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            foreach (string ausstattung in this.Anzeige.Auto.Ausstattung)
            {
                listBox.Items.Add(ausstattung);
                listBox.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }

            return listBox;
        }

        private void btnAddToExport_Click(object sender, EventArgs e)
        {
        }

        private void btnOeffnen_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(this.Anzeige.URL) == true) return;

            Process.Start(this.Anzeige.URL);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            EventPool.TriggerDeleteAnzeige(this.Anzeige);

            this.Close();
        }
    }
}
