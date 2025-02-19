using Fleck;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main()
        {
            var server = new WebSocketServer("ws://127.0.0.1:8080");

            server.Start(socket =>
            {
                socket.OnMessage = message =>
                {
                    var data = JsonConvert.DeserializeObject<PageData>(message);
                    Console.WriteLine($"🌍 URL erhalten: {data.Url}");
                    Console.WriteLine($"📄 HTML-Inhalt erhalten ({data.Html.Length} Zeichen)");

                    VerarbeiteURL(data.Html);
                };
            });

            Console.WriteLine("WebSocket-Server läuft auf ws://127.0.0.1:8080");
            Console.ReadLine();
        }

        static void VerarbeiteURL(string url)
        {
            Console.WriteLine($"🌍 Aufgerufene URL: {url}");

            if (url.Contains("963944"))
            {
                Console.WriteLine("Telnr komplett enthalten");
            } else Console.WriteLine("AMK HS");



            // Hier kannst du die URL weiterverwenden (z. B. speichern, analysieren, öffnen etc.)
        }
    }
    class PageData
    {
        public string Url { get; set; }
        public string Html { get; set; }
    }
}
