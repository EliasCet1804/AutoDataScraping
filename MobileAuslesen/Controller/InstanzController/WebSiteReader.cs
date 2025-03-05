using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.InstanzController
{
    internal class WebSiteReader
    {
        #region Properties
        private HttpClient HttpClient { get; set; }
        private HtmlDocument Document { get; set; }
        #endregion

        #region Konstruktoren
        public WebSiteReader()
        {
            this.HttpClient = new HttpClient(new HttpClientHandler { UseCookies = true });
            this.Document = new HtmlDocument();
        }
        #endregion

        #region Methoden

        internal async Task<string> GetHtmlCode(string url)
        {
            // Vorabüberprüfung
            if (string.IsNullOrEmpty(url) || HttpClient == null) return null;

            try
            {
                // User-Agent setzen, um wie ein Browser zu erscheinen
                HttpClient.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
                HttpClient.DefaultRequestHeaders.AcceptLanguage.ParseAdd("de-DE,de;q=0.9,en-US;q=0.8,en;q=0.7");
                HttpClient.DefaultRequestHeaders.Referrer = new Uri(url);

                //Lese html und gebe zurück
                return await HttpClient.GetStringAsync(url);

            } catch (HttpRequestException ex)
            {
                // Ausnahmebehandlung, falls die Anfrage fehlschlägt
                Console.WriteLine($"Fehler beim Abrufen der URL: {ex.Message}");
                return null;
            }
        }


        internal async Task<HtmlDocument> GetHtmlDocument(string url)
        {
            // Vorabüberprüfung
            if (string.IsNullOrEmpty(url) || HttpClient == null) return null;

            try
            {
                //Bekomme htmlCode
                var html = await GetHtmlCode(url);
                if (html == null) return null;

                // HTML-Dokument laden
                var document = new HtmlDocument();
                document.LoadHtml(html);

                return document;
            } catch (HttpRequestException ex)
            {
                // Ausnahmebehandlung, falls die Anfrage fehlschlägt
                Console.WriteLine($"Fehler beim Abrufen der URL: {ex.Message}");
                return null;
            }
        }

        #endregion
    }
}
