using MobileAuslesen.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MobileAuslesen.Controller.InstanzController;

namespace MobileAuslesen.Controller.StaticController
{
    internal class AnzeigenController
    {
        #region Public
        public static Anzeige GetAnzeige(HtmlDocument doc)
        {
            //Erstelle neue Anzeige
            Anzeige anzeige = new Anzeige();

            //Hole Titel und füge der Anzeige hinzu
            anzeige.Titel = GetAnzeigenTitel(doc);

            //Füge der Anzeige den dazugehörigen Preis hinzu
            anzeige.Preis = GetAnzeigenPreis(doc);

            //Hole Anzeigenbeschreibung und der Anzeigenbeschreibung hinzu
            anzeige.Beschreibung = GetAnzeigenBeschreibung(doc);

            //Hole KurzBeschreibung und füge der Anzeige hinzu
            anzeige.Kurzbeschreibung = GetAnzeigenKurzbeschreibung(doc);

            //Hole Anbieter und füge der Anzeige hinzu
            anzeige.Anbieter = AnbieterController.GetAnbieter(doc);

            //Füge Auto der Anzeige hinzu
            anzeige.Auto = AutoController.GetAuto(doc);

            return anzeige;
        }

        public static async Task<List<Anzeige>> LoadAnzeigen()
        {
            //Lade AnzeigenListe und überprüfe
            var anzeigenListe = StorageController.GetAnzeigeListeFromDrive();
            if (anzeigenListe == null) return null;

            //Filter nicht aktuelle anzeigen raus
            anzeigenListe = await CheckVerfuegbar(anzeigenListe);

            return anzeigenListe;

        }
        #endregion

        #region Private
        private static string GetAnzeigenTitel(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Wähle die Beschreibung
            var node = doc.DocumentNode.SelectSingleNode("//h2[@class='dNpqi']");
            if (node == null) return null;

            //Dekodiert ggf. Sonderzeichen und umlaute
            string titel = WebUtility.HtmlDecode(node.InnerText);

            return titel;
        }

        private static string GetAnzeigenKurzbeschreibung(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Wähle die Beschreibung
            var node = doc.DocumentNode.SelectSingleNode("//div[@class='GOIOV fqe3L EevEz']");
            if (node == null) return null;

            //Dekodiert ggf. Sonderzeichen und umlaute
            string kurzBeschreibung = WebUtility.HtmlDecode(node.InnerText);

            return kurzBeschreibung;
        }

        private static string GetAnzeigenBeschreibung(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Wähle die Beschreibung
            var node = doc.DocumentNode.SelectSingleNode("//article[@class='A3G6X lAeeF vTKPY']//div[@data-testid='vip-vehicle-description-content']");
            if (node == null) return null;

            //Dekodiert ggf. Sonderzeichen und umlaute
            string beschreibung = WebUtility.HtmlDecode(node.InnerHtml);

            beschreibung = "<h3>Fahrzeugbeschreibung laut Anbieter</h3><hr>" + beschreibung;

            return beschreibung;
        }

        private static int GetAnzeigenPreis(HtmlDocument doc)
        {
            if (doc == null) return -1;

            var node = doc.DocumentNode.SelectSingleNode("//div[@data-testid='vip-price-label']");
            if (string.IsNullOrEmpty(node.InnerText) == true) return -1;

            int preis = (int)ConvertController.ConvertInTypeFormat(typeof(int), node.InnerText);

            return preis;
        }

        private static async Task<List<Anzeige>> CheckVerfuegbar(List<Anzeige> anzeigenListe)
        {
            //Vorabüberprüfung
            if (anzeigenListe == null) return null;

            //Initalisiere einen neuen WebSiteReader
            WebSiteReader reader = new WebSiteReader();

            //Initialisere eine neue AnzeigenListe, die zurückgegeben wird
            List<Anzeige> result = new List<Anzeige>();

            //Gehe jede anzeige in der alten anzeigenliste durch
            foreach (Anzeige anzeige in anzeigenListe)
            {
                //Überprüfe, ob url gefüllt und ob url korrekt ist
                if (string.IsNullOrEmpty(anzeige.URL) || Uri.TryCreate(anzeige.URL, UriKind.Absolute, out Uri uriresult) == false) continue;

                //Lese website ein und überprüfe das htmldocument, wenn null ist die anzeige nicht mehr verfügbar
                var htmldoc = await reader.GetHtmlDocument(anzeige.URL);
                if (htmldoc == null) continue;

                //Füge die Anzeige dem result hinzu
                result.Add(anzeige);
            }

            //Gebe result zurück
            return result;
        }
        #endregion




    }
}
