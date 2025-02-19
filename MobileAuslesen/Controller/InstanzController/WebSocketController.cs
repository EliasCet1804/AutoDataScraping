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

                    data.HtmlCode = WebUtility.HtmlDecode(data.HtmlCode);

                    WebSocketEventPool.TriggerMessageReceive(data);
                };
            });

            Console.WriteLine("WebSocket-Server läuft auf ws://127.0.0.1:8080");
            Console.ReadLine();
        }

    }
}
