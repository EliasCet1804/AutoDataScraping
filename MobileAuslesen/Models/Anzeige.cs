using Fleck;
using MobileAuslesen.Controller.StaticController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    internal class Anzeige
    {
        #region Properties
        public int ID { get; set; } = -1;
        public string URL { get; set; }
        public string Titel { get; set; }
        public string Kurzbeschreibung { get; set; }
        public int Preis { get; set; }
        public Auto Auto { get; set; }
        public string Beschreibung { get; set; }
        public Anbieter Anbieter { get; set; }

        public string AnbieterName
        {
            get
            {
                //Vorabüberprüfung
                if (Anbieter == null || string.IsNullOrEmpty(Anbieter.Name) == true) return "";

                return Anbieter.Name;

            }
        }

        #endregion

        #region Konstruktoren
        public Anzeige() { }
        public Anzeige(string url)
        {
            if (string.IsNullOrEmpty(url) || url.Contains("id=") == false) throw new ArgumentNullException("url");

            URL = url;

            string id = url.Split('=')[1].Split('&')[0];
            int tmpID = -1;
            int.TryParse(id, out tmpID);

            this.ID = tmpID;

        }
        #endregion

        #region Methoden 

        public Dictionary<string, string> GetAnbieterInformationen()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "Ist Händler", this.Anbieter.IsHaendler ? "Ja" : "Nein" },
                { "Name", this.Anbieter.Name },
                { "Ort", this.Anbieter.Ort },
                { "Tel. Nummer", this.Anbieter.TelNummer },
                { "Bewertung", this.Anbieter.Bewertung.ToString() },
                { "Angemeldet seit", this.Anbieter.AngemeldetSeit.ToString() },
            };

            return dict;
        }

        public Dictionary<string, string> GetSonstigeInformationen()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "Leistung", ConvertController.IntegerWithDotsAndSuffix(this.Auto.Leistung, "PS") },
                { "Getriebeart", this.Auto.Getriebeart.ToString() },
                { "Fahrzeughalter", this.Auto.Fahrzeughalter.ToString() },
                { "HU", ConvertController.ConvertDateTimeInFormat(this.Auto.HU) },
                { "Kategorie", this.Auto.Fahrzeugart.ToString() },
                { "Farbe", this.Auto.Farbe },
            };

            return dict;
        }

        public Dictionary<string, string> GetGrundLagenInformationen()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "Titel", this.Titel },
                { "Kurzbeschreibung", this.Kurzbeschreibung },
                { "Preis", ConvertController.IntegerWithDotsAndSuffix(this.Preis, "€") },
                { "Kilometerstand", ConvertController.IntegerWithDotsAndSuffix(this.Auto.Kilometerstand, "km") },
                { "Erstzulassung", ConvertController.ConvertDateTimeInFormat(this.Auto.Erstzulassung) },
                { "Kraftstoffart", this.Auto.Kraftstoffart.ToString() }
            };

            return dict;
        }

        public void AddAutoInformation(Dictionary<string, string> infos)
        {
            //Vorabüberprüfung
            if (this.Auto == null) this.Auto = new Auto();

            //Füge dem Auto die gesammelten informationen hinzu
            this.Auto.AddInformation(infos);

        }

        #endregion

    }
}
