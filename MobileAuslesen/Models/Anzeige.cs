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
