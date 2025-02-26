using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Core
{
    internal class EnumDefinition
    {

        public enum MessageArt
        {
            None = 0,
            ConfigMessage = 2,
            AnzeigenMessage = 1,
        }

        public enum Kraftstoffart
        {
            None = 0,
            Benzin = 1,
            Diesel = 2,

        }

        public enum GetriebeArt
        {
            None = 0,
            Automatik = 1,
            Schaltgetriebe = 2,
        }

        public enum Fahrzeugart
        {
            None = 0,
            Kombi = 1,
            Coupe = 2,
            Cabrio = 3,
            Limousine = 4,
            SUV = 5,
            Kleinwagen = 6,
        }

        public enum Schadstoffklassen
        {
            None = 0,
            Euro1 = 1,
            Euro2 = 2,
            Euro3 = 3,
            Euro4 = 4,
            Euro5 = 5,
            Euro6 = 6,
        }

    }
}
