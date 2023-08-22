

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalNote
{
    // Represents a clinical note entry
    public class ClinicalNotes
    {
        // Properties for clinical note attributes
        public int NoteID { get; set; }
        public string PatientName { get; set; }
        public string ContentOfNotes { get; set; }
        public List<string> Problems { get; set; }
        public List<string> counting => Vitals.GetVitals(ContentOfNotes);

        // Constructor for creating a new clinical note
        public ClinicalNotes(int noteid, string patientName, DateTime dateOfBirth, string content)
        {
            NoteID = noteid;
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            ContentOfNotes = content;
            Problems = new List<string>();
        }

        private DateTime _dateOfBirth;
        // Property for handling Date of Birth with validation
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (!(value > DateTime.Now))
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("Date of Birth should not be in the future");
                }
            }
        }

        // Constructor for creating a clinical note from text data
        public ClinicalNotes(string text)
        {
            string[] data = text.Split("|");
            if (data.Length >= 5)
            {
                NoteID = int.Parse(data[0]);
                PatientName = data[1];
                DateOfBirth = DateTime.Parse(data[2]);
                ContentOfNotes = data[3];
                Problems = new List<string>(data[4].Split(";"));
            }
            else
            {
                throw new ArgumentException();
            }

        }

        // Converts clinical note data to a formatted text file representation
        public string ConvertToTextFile()
        {
            string formattedProblem = string.Join(";", Problems);
            string formattedContent = ContentOfNotes.Replace("\n", "\\n");
            return $"{NoteID} | {PatientName} | {DateOfBirth} | {formattedContent} | {formattedProblem} ";
        }

        // Overrides ToString method to display a concise representation of the clinical note
        public override string ToString()
        {
            return $"{NoteID} - {PatientName}";
        }
    }
}
