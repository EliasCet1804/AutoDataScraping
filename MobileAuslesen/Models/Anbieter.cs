using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    internal class Anbieter
    {
        public bool IsHaendler { get; set; } = true;

        //Standard Information ggf. optional
        public string Name { get; set; } = "Privatanbieter";
        public string Ort { get; set; }
        public string TelNummer { get; set; }

        //Händler Daten
        public float Bewertung { get; set; }
        public int AngemeldetSeit { get; set; }
        public int InserateOnline { get; set; }
        public int Weiterempfehlungsrate { get; set; }
        public int KfzWieBeschrieben { get; set; }
    }
}
