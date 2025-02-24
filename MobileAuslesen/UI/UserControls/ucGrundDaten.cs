using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            //anzeige.Auto.Kilometerstand.ToString() + " km"
            this.txtTitel.AddInfos("Titel", anzeige.Titel, true);
            this.txtKurzBeschreibung.AddInfos("Kurzbeschreibung", anzeige.Kurzbeschreibung, true);
            this.txtPreis.AddInfos("Preis", ConvertController.IntegerWithDotsAndSuffix(anzeige.Preis, "€"), true);
            this.txtKilometer.AddInfos("Kilometerstand", ConvertController.IntegerWithDotsAndSuffix(anzeige.Auto.Kilometerstand, "km"), true);
            this.txtErstzulassung.AddInfos("Erstzulassung", ConvertController.ConvertDateTimeInFormat(anzeige.Auto.Erstzulassung), true);

            changeSplitPos();
        }

        private void changeSplitPos()
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

        private void ucGrundDaten_Load(object sender, EventArgs e)
        {

        }
    }
}
