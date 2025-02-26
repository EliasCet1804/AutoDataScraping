using MobileAuslesen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.Controller.StaticController
{
    internal class ConfigController
    {
        public static Config GetConfig()
        {
            //Erstelle configPath
            string configPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "config.json");
            if (File.Exists(configPath) == false) return new Config();

            //Lese config aus
            string jsonString = File.ReadAllText(configPath);

            //Erstelle aus json die Config, falls null erstelle neue
            var config = JsonConvert.DeserializeObject<Config>(jsonString);
            if (config == null) config = new Config();

            //Gebe Config zurück
            return config;
        }
    }
}
