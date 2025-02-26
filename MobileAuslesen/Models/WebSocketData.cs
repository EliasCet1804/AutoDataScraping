using MobileAuslesen.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    internal class WebSocketData
    {
        [JsonProperty("Art")]
        public EnumDefinition.MessageArt Art { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Html")]
        public string HtmlCode { get; set; }



    }
}
