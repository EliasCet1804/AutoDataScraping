using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    public class Bild
    {
        [JsonIgnore]
        private Image image { get; set; }

        public string URL { get; set; }

        public byte[] Bytes { get; set; }

        [JsonIgnore]
        public Image Image
        {
            get
            {
                if (this.image == null)
                {
                    using (MemoryStream ms = new MemoryStream(this.Bytes))
                    {
                        this.image = Image.FromStream(ms);

                    }
                }

                return this.image;
            }
            set { this.image = value; }
        }

        public Bild() { }
        public Bild(string uRL, byte[] bytes, Image image)
        {
            URL = uRL;
            Bytes = bytes;
            Image = image;
        }
        public Bild(string URL, byte[] bytes)
        {
            this.URL = URL;
            this.Bytes = bytes;
        }

        public Bild(byte[] bytes)
        {
            this.Bytes = bytes;
        }
    }
}
