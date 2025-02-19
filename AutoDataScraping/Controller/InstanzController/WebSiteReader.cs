using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoDataScraping.Controller.InstanzController
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

        internal HtmlDocument GetHtmlDocument(string url)
        {
            // Vorabüberprüfung
            if (string.IsNullOrEmpty(url)) return null;

            try
            {
                // Selenium WebDriver für Chrome
                using (IWebDriver driver = new ChromeDriver())
                {
                    // Seite laden
                    driver.Navigate().GoToUrl(url);

                    // Warten, bis die Seite vollständig geladen ist
                    Thread.Sleep(2000); // Optionale Wartezeit, um sicherzustellen, dass die Seite geladen ist

                    // Überprüfen, ob der Button vorhanden ist und auf ihn klicken
                    var button = driver.FindElement(By.XPath("//div[@aria-pressed='false' and @role='button']"));
                    if (button != null)
                    {
                        button.Click();
                        Thread.Sleep(10000); // Warten, damit die Seite nach dem Klick aktualisiert wird
                    }

                    // Nach dem Klick das HTML der Seite abrufen
                    string html = driver.PageSource;

                    // HTML-Dokument laden
                    var document = new HtmlDocument();
                    document.LoadHtml(html);

                    return document;
                }
            } catch (Exception ex)
            {
                // Ausnahmebehandlung, falls die Anfrage fehlschlägt
                Console.WriteLine($"Fehler beim Abrufen der URL: {ex.Message}");
                return null;
            }

        }

        #endregion
    }
}
