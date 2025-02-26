using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Models;
using MobileAuslesen.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.UI
{
    public partial class frmAnzegei2 : Form
    {
        private Anzeige Anzeige = null;

        internal frmAnzegei2(Anzeige anzeige)
        {
            InitializeComponent();

            this.Anzeige = anzeige;

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetGrundLagenInformationen(), "Grundlagen"), 0, 0);
            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetSonstigeInformationen(), "Sonstige Informationen"), 1, 0);
            tableLayoutPanel1.Controls.Add(new ucTextControl(this.Anzeige.GetAnbieterInformationen(), "Anbieter Informationen"), 2, 0);

            FillListBox();

        }

        private void FillListBox()
        {
            foreach (string ausstattung in this.Anzeige.Auto.Ausstattung)
            {
                this.listBox1.Items.Add(ausstattung);
                this.listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }

        private void btnAddToExport_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Size.ToString());


            Console.WriteLine(tableLayoutPanel1.Controls[0].Size.ToString());
        }

    }
}
