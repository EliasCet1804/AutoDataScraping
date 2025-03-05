using MobileAuslesen.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileAuslesen.Controller.InstanzController;

namespace MobileAuslesen.Controller.StaticController
{
    internal class AutoController
    {

        public static Auto GetAuto(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Erstelle neues Auto
            Auto auto = new Auto();

            //Hole Technische daten vom Auto
            var dictTechnischeDaten = GetTechnischeDaten(doc);
            if (dictTechnischeDaten == null || dictTechnischeDaten.Count < 1) return null;

            //Füge Technische Daten dem Auto hinzu
            auto.AddInformation(dictTechnischeDaten);

            //Hole Ausstattung vom Auto
            List<string> ausstattung = GetAusstattung(doc);
            if (ausstattung == null || ausstattung.Count < 1) return null;

            //Füge Ausstattung dem Auto hinzu
            auto.Ausstattung = ausstattung;

            return auto;
        }
        //vip-features-list
        private static List<string> GetAusstattung(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Wähle Ausstattung Nodes aus
            var nodes = doc.DocumentNode.SelectNodes(ConfigController.Instance.Config.HtmlConfig.AutoAusstattungNode);

            List<string> ausstattungsListe = new List<string>();
            foreach (var node in nodes)
            {
                ausstattungsListe.Add(node.InnerText);
            }

            return ausstattungsListe;
        }

        private static Dictionary<string, string> GetTechnischeDaten(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            //Wähle Teschnische Daten Nodes aus
            var nodes = doc.DocumentNode.SelectNodes(ConfigController.Instance.Config.HtmlConfig.AutoTechnischeDatenNode);

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            foreach (var node in nodes)
            {
                string key = node.InnerText.Trim();
                var ddNode = node.SelectSingleNode(ConfigController.Instance.Config.HtmlConfig.AutoTechnischeDatenFollowSibilingNode);
                string value = ddNode.InnerText.Trim();

                keyValuePairs.Add(key, value);
            }

            return keyValuePairs;
        }
    }
}
