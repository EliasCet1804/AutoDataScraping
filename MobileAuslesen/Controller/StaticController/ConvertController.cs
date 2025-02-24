using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileAuslesen.Controller.StaticController
{
    internal class ConvertController
    {

        internal static object ConvertInTypeFormat(Type targetType, string value)
        {
            //Vorabüberprüfung
            if (value == null || targetType == null) return null;

            // Entferne Tausenderpunkte und Einheiten wie "km"
            value = RemoveUnits(value);

            // Wenn der Zieltyp ein Enum ist, konvertiere ihn
            if (targetType.IsEnum)
            {
                Match match = Regex.Match(value, @"\d+");
                if (match.Success) value = match.Value;

                value = value.Replace(" ", "");

                if (value.Contains("/")) value = value.Split('/')[0];

                if (value == "Schalter") value = "Schaltgetriebe";

                var enumValue = Enum.Parse(targetType, value, true);
                return enumValue;
            }

            //Parse in den jeweiligen typ
            if (targetType == typeof(string)) return value;
            else if (targetType == typeof(int)) return int.TryParse(value, out var intValue) ? intValue : 0;
            else if (targetType == typeof(DateTime)) return DateTime.TryParse(value, out var dateTimeValue) ? dateTimeValue : DateTime.MinValue;
            else if (targetType == typeof(bool)) return bool.TryParse(value, out var boolValue) ? boolValue : false;

            // Fallback auf ChangeType für andere Typen
            return Convert.ChangeType(value, targetType);
        }

        // Methode, um Tausenderpunkte zu entfernen und Einheiten wie "km" zu löschen
        internal static string RemoveUnits(string value)
        {
            // Entferne Tausendertrennzeichen (z. B. Punkte in "115.000")
            value = value.Replace(".", "").Trim();

            //Wenn der value eine Leistungsangabe ist
            Match match = Regex.Match(value, @"(\d+)\s*PS");
            if (match.Success) return match.Groups[1].Value;

            match = Regex.Match(value, @"\d{1,2},\d\s*l\/100km");
            if (match.Success) return match.Value.Split(' ')[0];

            // Entferne alle Einheiten wie "km", "€", "m", etc.
            var units = new[] { "km", "€", "m", "cm", "%", "cm³", "l/100 (kombiniert)" }; // Hier kannst du beliebige Einheiten hinzufügen
            foreach (var unit in units)
            {
                if (value.EndsWith(unit))
                    value = value.Replace(unit, "").Trim();
            }

            return value;
        }

        internal static string IntegerWithDotsAndSuffix(int zahl, string suffix = "")
        {
            //setzte ggf. suffix ins richtige format
            if (string.IsNullOrEmpty(suffix) == false) suffix = " " + suffix.Trim();

            //Formatiere die Zahl mit . bei tausender
            string formattierteZahl = zahl.ToString("N0", CultureInfo.GetCultureInfo("de-DE"));

            //gebe formatierteZahl und suffix zurück
            return formattierteZahl + suffix;

        }

        internal static string ConvertDateTimeInFormat(DateTime date)
        {
            return date.ToString("MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
