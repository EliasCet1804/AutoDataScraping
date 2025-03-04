using MobileAuslesen.Controller.StaticController;
using MobileAuslesen.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    internal class Auto
    {
        #region Standard Informationen
        [JsonProperty("Kilometerstand")]
        public int Kilometerstand { get; set; }

        [JsonProperty("Leistung")]
        public int Leistung { get; set; }

        [JsonProperty("Kraftstoffart")]
        public string Kraftstoffart { get; set; }

        [JsonProperty("Getriebe")]
        public string Getriebeart { get; set; }

        [JsonProperty("Erstzulassung")]
        public DateTime Erstzulassung { get; set; }

        [JsonProperty("Anzahl der Fahrzeughalter")]
        public int Fahrzeughalter { get; set; }
        #endregion

        #region Sonstiges
        [JsonProperty("Fahrzeugzustand")]
        public string Fahrzeugzustand { get; set; }

        [JsonProperty("Kategorie")]
        public string Fahrzeugart { get; set; }

        [JsonProperty("Fahrzeugnummer")]
        public string Fahrzeugnummer { get; set; }

        [JsonProperty("Herkunft")]
        public string Herkunft { get; set; }

        [JsonProperty("Hubraum")]
        public int Hubraum { get; set; }

        [JsonProperty("Kraftstoffverbrauch2")]
        public float EnergieverbrauchKombiniert { get; set; }

        [JsonProperty("Anzahl Sitzplätze")]
        public int AnzahlSitze { get; set; }

        [JsonProperty("Anzahl der Türen")]
        public string AnzahlTuer { get; set; }

        [JsonProperty("Schadstoffklasse")]
        public string Schadstoffklasse { get; set; }

        [JsonProperty("HU")]
        public DateTime HU { get; set; }

        [JsonProperty("Farbe (Hersteller)")]
        public string HerstellerFarbe { get; set; }

        [JsonProperty("Farbe")]
        public string Farbe { get; set; }

        public List<string> Ausstattung { get; set; }

        #endregion

        #region Konstruktoren

        public Auto() { }
        public Auto(Dictionary<string, string> infos) { AddInformation(infos); }

        #endregion

        #region Methoden
        public void AddInformation(Dictionary<string, string> infos)
        {
            // Hole alle Properties der Klasse
            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                //Vorabüberprüfung
                if (property.CanWrite == false) continue;

                //Ziehe aus der Property den JsonName
                var jsonAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();

                //Falls JsonName, nicht vorhanden ist, nehme den normalen property Name
                string key = jsonAttribute?.PropertyName ?? property.Name;

                // Wenn die info nicht vorhanden ist, überspringe
                if (!infos.ContainsKey(key)) continue;

                // Versuche, die aktuelle info zu bekommen
                infos.TryGetValue(key, out var info);

                if (property.PropertyType == typeof(Single))
                {

                }

                // Konvertiere den Wert und setze die Property
                var convertedValue = ConvertController.ConvertInTypeFormat(property.PropertyType, info);
                property.SetValue(this, convertedValue);
            }
        }



        #endregion
    }
}
