using MobileAuslesen.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.StaticController
{
    internal class AnzeigenController
    {
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
            var node = doc.DocumentNode.SelectSingleNode("//div[@data-testid='vip-vehicle-description-text']");
            if (node == null) return null;

            //Dekodiert ggf. Sonderzeichen und umlaute
            string beschreibung = WebUtility.HtmlDecode(node.InnerText);

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

    }
}
