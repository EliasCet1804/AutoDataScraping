using MobileAuslesen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.Controller.InstanzController
{
    internal class ConfigController
    {
        private Config config { get; set; }
        public Config Config
        {
            get
            {
                if (config == null)
                {
                    this.config = GetConfig();
                }

                return this.config;
            }
            set
            {
                this.config = value;
            }
        }

        #region Singleton

        private static ConfigController _Instance = null;
        public static ConfigController Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ConfigController();
                }
                return _Instance;
            }
        }

        #endregion

        private Config GetConfig()
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
