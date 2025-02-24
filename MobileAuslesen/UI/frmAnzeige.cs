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

            pnlInformationen.Controls.Add(CreateGrundLagenControl());
            pnlInformationen.Controls.Add(CreateSonstigeInformationen());

        }

        private ucTextControl CreateSonstigeInformationen()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Leistung", ConvertController.IntegerWithDotsAndSuffix(this.Anzeige.Auto.Leistung, "PS"));
            dict.Add("Kurzbeschreibung", this.Anzeige.Kurzbeschreibung);
            dict.Add("Preis", ConvertController.IntegerWithDotsAndSuffix(this.Anzeige.Preis, "€"));
            dict.Add("Kilometerstand", ConvertController.IntegerWithDotsAndSuffix(this.Anzeige.Auto.Kilometerstand, "km"));
            dict.Add("Erstzulassung", ConvertController.ConvertDateTimeInFormat(this.Anzeige.Auto.Erstzulassung));

            ucTextControl uc = new ucTextControl(dict, "Sonstige Informationen");
            uc.Dock = DockStyle.Left;

            return uc;
        }

        private ucTextControl CreateGrundLagenControl()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Titel", this.Anzeige.Titel);
            dict.Add("Kurzbeschreibung", this.Anzeige.Kurzbeschreibung);
            dict.Add("Preis", ConvertController.IntegerWithDotsAndSuffix(this.Anzeige.Preis, "€"));
            dict.Add("Kilometerstand", ConvertController.IntegerWithDotsAndSuffix(this.Anzeige.Auto.Kilometerstand, "km"));
            dict.Add("Erstzulassung", ConvertController.ConvertDateTimeInFormat(this.Anzeige.Auto.Erstzulassung));

            ucTextControl uc = new ucTextControl(dict, "Grundlagen");
            uc.Dock = DockStyle.Left;

            return uc;

        }

        private void btnOeffnen_Click_1(object sender, EventArgs e)
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
