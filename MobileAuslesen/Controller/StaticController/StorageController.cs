using MobileAuslesen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.Controller.StaticController
{
    internal class StorageController
    {

        private static void WriteDataToDrive(string filePath, string text)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(text) || Path.IsPathRooted(filePath) == false) return;

            //Hole auf FilePath den DirectoryPath
            string directoryPath = Path.GetDirectoryName(filePath);

            //falls der Ordner noch nicht exestiert: erstelle
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            //Erstelle file und fülle mit text
            File.WriteAllText(filePath, text);
        }

        private static string LoadDataFromDrive(string filePath)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(filePath) || Path.IsPathRooted(filePath) == false || File.Exists(filePath) == false) return null;

            //Lese Daten von der Festplatte und gebe zurück
            return File.ReadAllText(filePath);
        }

        public static List<Anzeige> GetAnzeigeListeFromDrive()
        {
            //Setze FilePath zusammen
            var filePath = Path.Combine(Application.StartupPath, "data", "anzeigen.json");

            //Lese daten von der Festplatte und überprüfe
            string jsonString = LoadDataFromDrive(filePath);
            if (string.IsNullOrEmpty(jsonString)) return null;

            //erstelle aus jsonString die anzeigenListe und überprüfe
            List<Anzeige> anzeigenListe = JsonConvert.DeserializeObject<List<Anzeige>>(jsonString);
            if (anzeigenListe == null || anzeigenListe.Count == 0) return null;

            //Gebe anzeigenListe zurück
            return anzeigenListe;

        }

        public static void SaveAnzeigenData(List<Anzeige> anzeigenListe)
        {
            //Vorabüberprüfung
            if (anzeigenListe == null || anzeigenListe.Count == 0) return;

            //Setze FilePath zusammen
            var filePath = Path.Combine(Application.StartupPath, "data", "anzeigen.json");

            //Generiere aus anzeigenListe den jsonString
            string jsonString = JsonConvert.SerializeObject(anzeigenListe);

            WriteDataToDrive(filePath, jsonString);
        }


    }
}
