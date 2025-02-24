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

        private Anzeige Anzeige;

        internal frmAnzeige(Anzeige anzeige)
        {
            InitializeComponent();

            this.Anzeige = anzeige;
            this.Text = "Ansicht: " + anzeige.Titel + " | " + anzeige.Kurzbeschreibung;

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            var ucgd = new ucGrundDaten(this.Anzeige);

            pnlGrundDaten.Controls.Add(ucgd);
            this.pnlGrundDaten.Size = ucgd.Size;
        }

        private void btnOeffnen_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(this.Anzeige.URL) == true) return;

            Process.Start(this.Anzeige.URL);
        }

    }
}
