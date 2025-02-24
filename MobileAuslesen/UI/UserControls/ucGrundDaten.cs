using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.UI.UserControls
{
    public partial class ucGrundDaten : UserControl
    {
        internal ucGrundDaten(Anzeige anzeige)
        {
            InitializeComponent();

            this.txtTitel.AddInfos("Titel", anzeige.Titel, true);
            this.txtKurzBeschreibung.AddInfos("Kurzbeschreibung", anzeige.Kurzbeschreibung, true);
            this.txtPreis.AddInfos("Preis", anzeige.Preis.ToString() + "€", true);

            changeSplitPos(null, null);
        }

        private void changeSplitPos(object sender, EventArgs e)
        {

            int maxSplitPos = -1;

            var items = this.Controls.OfType<ucTextBox>();

            foreach (ucTextBox uc in items)
            {
                if (uc.SplitPos > maxSplitPos) maxSplitPos = uc.SplitPos;
            }

            foreach (ucTextBox uc in items)
            {
                uc.setSplitPos(maxSplitPos);
            }
        }

    }
}
