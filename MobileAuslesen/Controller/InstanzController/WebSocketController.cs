using Fleck;
using MobileAuslesen.Events;
using MobileAuslesen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.InstanzController
{
    internal class WebSocketController
    {
        private WebSocketServer WebSocketServer;

        private static List<string> erlaubteDomains = new List<string> { "mobile.de" };

        public WebSocketController()
        {
            this.WebSocketServer = new WebSocketServer("ws://127.0.0.1:8080");

        }

        public void Start()
        {
            WebSocketServer.Start(socket =>
            {
                socket.OnMessage = message =>
                {
                    var data = JsonConvert.DeserializeObject<WebSocketData>(message);
                    Console.WriteLine($"🌍 URL erhalten: {data.Url}");
                    Console.WriteLine($"📄 HTML-Inhalt erhalten ({data.HtmlCode.Length} Zeichen)");

                    if (isErlaubteURL(data.Url) == false) return;

                    data.HtmlCode = WebUtility.HtmlDecode(data.HtmlCode);

                    WebSocketEventPool.TriggerMessageReceive(data);
                };
            });

            Console.WriteLine("WebSocket-Server läuft auf ws://127.0.0.1:8080");
            Console.ReadLine();
        }

        private bool isErlaubteURL(string url)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
                return false;

            foreach (var domain in erlaubteDomains)
            {
                if (uri.Host.EndsWith(domain, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }


    }
}
