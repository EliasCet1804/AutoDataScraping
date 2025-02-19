using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Events
{
    internal class WebSocketEventPool
    {
        internal static event EventHandler<WebSocketData> MessageReceive;
        internal static void TriggerMessageReceive(WebSocketData data)
        {
            MessageReceive?.Invoke(null, data);
        }
    }
}
