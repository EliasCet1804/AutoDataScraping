using MobileAuslesen.Controller.InstanzController;
using MobileAuslesen.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.StaticController
{
    class BildController
    {
        public static async Task<Bild> GetBildFromURLAsync(string url)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(url) == true) return null;

            //Erstelle neuen WebSiteReader
            WebSiteReader reader = new WebSiteReader();

            Bild bild = new Bild { URL = url };

            //Liese async die ImageBytes aus
            bild.Bytes = await reader.GetImageBytes(url);
            if (bild.Bytes == null || bild.Bytes.Length < 1) return null;

            //Benutze nen neuen MS um Image zuerstellen
            using (MemoryStream ms = new MemoryStream(bild.Bytes))
            {
                bild.Image = Image.FromStream(ms);
            }

            return bild;
        }

    }
}
