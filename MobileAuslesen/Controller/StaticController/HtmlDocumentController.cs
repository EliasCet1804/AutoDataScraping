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
        public static async Task<Anzeige> CreateAnzeigeAsync(WebSocketData data)
        {
            //Vorabüberprüfung
            if (data == null || string.IsNullOrEmpty(data.HtmlCode) || string.IsNullOrEmpty(data.Url)) return null;

            //Erstelle neues HtmlDocument und lade htmlcode rein
            var doc = new HtmlDocument();
            doc.LoadHtml(data.HtmlCode);

            //Erstelle anzeige
            var anzeige = await AnzeigenController.GetAnzeigeAsync(doc);
            anzeige.URL = data.Url;

            return anzeige;
        }
    }
}
