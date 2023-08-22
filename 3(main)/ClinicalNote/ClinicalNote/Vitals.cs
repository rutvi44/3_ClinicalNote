

using System.Text;
using System.Text.RegularExpressions;

namespace ClinicalNote
{
    // Represents a utility class for extracting vital signs information from text
    public class Vitals
    {
        // Regular expressions for extracting vital signs data
        private static readonly Regex RegexBP = new(@"(?:.*\bBP\s*:\s*)(\d+)\s*/\s*(\d+)\s*.*", RegexOptions.IgnoreCase);
        private static readonly Regex RegexHR = new(@"(?:.*\bHR\s*:\s*)(\d+)\s*.*", RegexOptions.IgnoreCase);
        private static readonly Regex RegexTemp = new(@"(?:.*\bT\s*:\s*)(\d+(?:\.\d+)?)\s*?.*", RegexOptions.IgnoreCase);
        private static readonly Regex RegexRR = new(@"(?:.*\bRR\s*:\s*)(\d+)\s*.*", RegexOptions.IgnoreCase);

        // Extracts vital signs information from the provided text and returns a list of measurements
        public static List<string> GetVitals(string data)
        {
            var measurementResults = new List<string>();
            var textlines = data.Split('\n');

            foreach (var line in textlines)
            {
                var measurementStringBuilder = new StringBuilder();

                if (TryExtractHR(line, measurementStringBuilder, out var hrValue))
                {
                    measurementResults.Add(measurementStringBuilder.ToString());
                }
                else if (TryExtractBP(line, measurementStringBuilder, out var systolicValue, out var diastolicValue))
                {
                    measurementResults.Add(measurementStringBuilder.ToString());
                }
                else if (TryExtractTemperature(line, measurementStringBuilder, out var tempValue))
                {
                    measurementResults.Add(measurementStringBuilder.ToString());
                }
                else if (TryExtractRR(line, measurementStringBuilder, out var rrValue))
                {
                    measurementResults.Add(measurementStringBuilder.ToString());
                }
            }

            return measurementResults;
        }

        // Extract Heart Rate (HR) data from the provided line and appends to the measurementBuilder
        private static bool TryExtractHR(string line, StringBuilder measurementBuilder, out int hrValue)
        {
            hrValue = 0;
            var hrMatch = RegexHR.Match(line);
            if (hrMatch.Success && int.TryParse(hrMatch.Groups[1].Value, out hrValue))
            {
                measurementBuilder.Append("HR: ");
                measurementBuilder.Append(hrValue);
                measurementBuilder.Append(" bpm");

                if (hrValue < 60)
                {
                    measurementBuilder.Append(" (LOW)");
                }
                else if (hrValue > 100)
                {
                    measurementBuilder.Append(" (HIGH)");
                }

                return true;
            }

            return false;
        }

        // Extract Blood Pressure (BP) data from the provided line and appends to the measurementBuilder
        private static bool TryExtractBP(string line, StringBuilder measurementBuilder, out int systolicValue, out int diastolicValue)
        {
            systolicValue = 0;
            diastolicValue = 0;
            var bpMatch = RegexBP.Match(line);
            if (bpMatch.Success && int.TryParse(bpMatch.Groups[1].Value, out systolicValue) &&
                int.TryParse(bpMatch.Groups[2].Value, out diastolicValue))
            {
                measurementBuilder.Append("BP: ");
                measurementBuilder.Append(systolicValue);
                measurementBuilder.Append("/");
                measurementBuilder.Append(diastolicValue);
                measurementBuilder.Append(" mmHg");

                if (systolicValue < 90 && diastolicValue < 60)
                {
                    measurementBuilder.Append(" (LOW)");
                }
                else if (systolicValue > 130 && diastolicValue > 80)
                {
                    measurementBuilder.Append(" (HIGH)");
                }

                return true;
            }

            return false;
        }

        // Extract Temperature (T) data from the provided line and appends to the measurementBuilder
        private static bool TryExtractTemperature(string line, StringBuilder measurementBuilder, out double tempValue)
        {
            tempValue = 0.0;
            var tempMatch = RegexTemp.Match(line);
            if (tempMatch.Success && double.TryParse(tempMatch.Groups[1].Value, out tempValue))
            {
                measurementBuilder.Append("T: ");
                measurementBuilder.Append(tempValue);
                measurementBuilder.Append(" °C");

                if (tempValue < 36.5)
                {
                    measurementBuilder.Append(" (LOW)");
                }
                else if (tempValue > 37.5)
                {
                    measurementBuilder.Append(" (HIGH)");
                }

                return true;
            }

            return false;
        }

        // Extract Respiratory Rate (RR) data from the provided line and appends to the measurementBuilder
        private static bool TryExtractRR(string line, StringBuilder measurementBuilder, out int rrValue)
        {
            rrValue = 0;
            var rrMatch = RegexRR.Match(line);
            if (rrMatch.Success && int.TryParse(rrMatch.Groups[1].Value, out rrValue))
            {
                measurementBuilder.Append("RR: ");
                measurementBuilder.Append(rrValue);
                measurementBuilder.Append(" bpm");

                if (rrValue < 12)
                {
                    measurementBuilder.Append(" (LOW)");
                }
                else if (rrValue > 16)
                {
                    measurementBuilder.Append(" (HIGH)");
                }

                return true;
            }

            return false;
        }
    }
}