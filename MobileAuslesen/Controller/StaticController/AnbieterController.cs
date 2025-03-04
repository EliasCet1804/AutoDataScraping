using MobileAuslesen.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using MobileAuslesen.Controller.InstanzController;

namespace MobileAuslesen.Controller.StaticController
{
    internal class AnbieterController
    {

        public static Anbieter GetAnbieter(HtmlDocument doc)
        {
            //Vorabüberprüfung
            if (doc == null) return null;

            Anbieter anbieter = new Anbieter();

            //Füge Name hinzu
            anbieter.Name = GetAnbieterName(doc);

            //Füge Ort hinzu
            anbieter.Ort = GetAnbieterOrt(doc);

            //Füge TelNummer hinzu
            anbieter.TelNummer = GetAnbieterTelNr(doc);

            //Wenn Anbieter Privat ist, setze infos und return
            if (anbieter.Name == "Privatanbieter")
            {
                anbieter.IsHaendler = false;
                return anbieter;
            }

            //----- nur noch Händler Informationen -----

            //Füge AngemeldetSeit hinzu
            anbieter.AngemeldetSeit = GetAnbieterAngemeldetSeit(doc);

            //Füge InserateOnline hinzu
            anbieter.InserateOnline = GetAnbieterInserateOnline(doc);

            //Füge WeiterEmpfehlungsrate hinzu
            anbieter.Weiterempfehlungsrate = GetAnbieterWeiterempfehlungsrate(doc);

            //Füge KfzWieBeschrieben hinzu
            anbieter.KfzWieBeschrieben = GetAnbieterKfzWieBeschrieben(doc);

            return anbieter;
        }

        private static string GetAnbieterName(HtmlDocument doc)
        {
            if (doc == null) return null;

            //Wähle Name-Node und überprüfe
            HtmlNode node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterNameNode);
            if (node == null) return null;

            //Name zurückgeben
            return node.InnerText;
        }

        private static string GetAnbieterOrt(HtmlDocument doc)
        {
            if (doc == null) return null;

            //Wöhle Ort-Node und überprüfe
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterOrtNode);
            if (node == null) return null;

            //Ort zurückgeben
            return node.InnerText;
        }

        private static string GetAnbieterTelNr(HtmlDocument doc)
        {
            if (doc == null) return null;

            //Wöhle TelNr-Node und füge ggf. anbieter hinzu
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterTelNrNode);
            if (node == null) return null;

            node = node.FirstChild.SelectSingleNode("span");
            if (node == null) return null;

            //TelNummer zurückgeben
            return node.InnerText;
        }

        private static int GetAnbieterAngemeldetSeit(HtmlDocument doc)
        {
            if (doc == null) return -1;

            //Wähle AngemeldetSeit-Node und überprüfe
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterAngemeldetSeitNode);
            if (node == null) return -1;

            //ziehe alle zahlen aus dem innertext
            Match match = Regex.Match(node.InnerText, @"\d+");
            if (match.Success == false) return -1;

            //Gibt die Jahre zurck
            return int.Parse(match.Value);
        }

        private static int GetAnbieterInserateOnline(HtmlDocument doc)
        {
            if (doc == null) return -1;

            //Wähle InserateOnline-Node und überprüfe
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterInserateOnlineNode);
            if (node == null) return -1;

            //ziehe alle zahlen aus dem innertext
            Match match = Regex.Match(node.InnerText, @"\d+");
            if (match.Success == false) return -1;

            //Gibt die Jahre zurck
            return int.Parse(match.Value);
        }

        private static int GetAnbieterWeiterempfehlungsrate(HtmlDocument doc)
        {
            if (doc == null) return -1;

            //Wähle Weiterempfehlungsrate-Node und überprüfe
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterWeiterEmpfehlungsRateNode);
            if (node == null) return -1;

            //ziehe alle zahlen aus dem innertext
            Match match = Regex.Match(node.InnerText, @"\d+");
            if (match.Success == false) return -1;

            //Gibt die Jahre zurck
            return int.Parse(match.Value);
        }

        private static int GetAnbieterKfzWieBeschrieben(HtmlDocument doc)
        {
            if (doc == null) return -1;

            //Wähle KfzWieBeschrieben-Node und überprüfe
            var node = doc.DocumentNode.SelectSingleNode(ConfigController.Instance.Config.AnbieterKfzWieBeschriebenNode);
            if (node == null) return -1;

            //ziehe alle zahlen aus dem innertext
            Match match = Regex.Match(node.InnerText, @"\d+");
            if (match.Success == false) return -1;

            //Gibt die Jahre zurck
            return int.Parse(match.Value);
        }

    }
}
