using MobileAuslesen.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.StaticController
{
    internal class HtmlDocumentController
    {
        public static Anzeige CreateAnzeige(WebSocketData data)
        {
            if (data == null || string.IsNullOrEmpty(data.HtmlCode) || string.IsNullOrEmpty(data.Url)) return null;

            var doc = new HtmlDocument();
            doc.LoadHtml(data.HtmlCode);

            var anzeige = AnzeigenController.GetAnzeige(doc);
            anzeige.URL = data.Url;

            return anzeige;
        }


        private static int GetAnzeigenPreis(HtmlDocument doc)
        {
            var node = doc.DocumentNode.SelectSingleNode("//div[@data-testid='vip-price-label']");
            if (string.IsNullOrEmpty(node.InnerText) == true) return -1;

            int preis = (int)ConvertController.ConvertInTypeFormat(typeof(int), node.InnerText);

            return preis;
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




    }
}
