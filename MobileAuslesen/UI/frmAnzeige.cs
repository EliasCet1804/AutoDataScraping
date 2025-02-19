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

namespace MobileAuslesen.UI
{
    public partial class frmAnzeige : Form
    {
        private Anzeige Anzeige;

        internal frmAnzeige(Anzeige anzeige)
        {
            InitializeComponent();

            this.Anzeige = anzeige;

            this.Text += anzeige.Titel + " | " + anzeige.Kurzbeschreibung;
        }
    }
}
