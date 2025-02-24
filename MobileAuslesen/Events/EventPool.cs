using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Events
{
    internal class EventPool
    {

        internal static event EventHandler<Anzeige> DeleteAnzeige;
        internal static void TriggerDeleteAnzeige(Anzeige anzeige)
        {
            DeleteAnzeige?.Invoke(null, anzeige);
        }

    }
}
