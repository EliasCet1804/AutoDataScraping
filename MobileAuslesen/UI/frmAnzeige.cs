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

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            List<ucTextControl> ucTextControls = new List<ucTextControl>
            {
                new ucTextControl(this.Anzeige.GetGrundLagenInformationen(), "Grundlagen"),
                new ucTextControl(this.Anzeige.GetSonstigeInformationen(), "Sonstige Informationen"),
                new ucTextControl(this.Anzeige.GetAnbieterInformationen(), "Anbieter Informationen"),
                new ucTextControl(GetAusstatungsListBox(), "Ausstattung"),
                new ucTextControl(GetBeschreibungsLabel(), "Beschreibung")
            };

            int x = 0;
            int y = 0;
            foreach (ucTextControl uc in ucTextControls)
            {
                if (x == 3)
                {
                    x = 0; y = 1;
                }
                uc.Dock = DockStyle.Fill;

                tableLayoutPanel1.Controls.Add(uc, x, y);

                if (x == 1 && y == 1) tableLayoutPanel1.SetColumnSpan(uc, 2);

                x++;


            }
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
