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
            this.HttpClient = new HttpClient();
            this.Document = new HtmlDocument();
        }
        #endregion

        #region Methoden

        internal async Task<HtmlDocument> GetHtmlDocumenthttp(string url)
        {
            // Vorabüberprüfung
            if (string.IsNullOrEmpty(url) || HttpClient == null) return null;

            try
            {
                // User-Agent setzen, um wie ein Browser zu erscheinen
                HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                // HTML von der URL abrufen
                string html = await HttpClient.GetStringAsync(url);

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
