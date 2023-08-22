
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClinicalNote
{
    // Class responsible for managing data storage and retrieval
    public class AllData
    {
        // Delete the entire data file
        private static void DeletAllData()
        {
            File.Delete("AllEncounterNotes.txt");
        }

        // Retrieve all clinical notes from the data file
        public List<ClinicalNotes> GetAllData()
        {
            try
            {
                // Open the data file for reading

                using (var documentFile = File.Open("AllEncounterNotes.txt", FileMode.OpenOrCreate))
                using (var documentReader = new StreamReader(documentFile))
                {
                    string? documentLine;
                    var datalist = new List<ClinicalNotes>();

                    // Read each line from the file and create ClinicalNotes objects

                    while ((documentLine = documentReader.ReadLine()) != null)
                    {
                        ClinicalNotes clinicalnotes = new ClinicalNotes(documentLine);
                        clinicalnotes.ContentOfNotes = clinicalnotes.ContentOfNotes.Replace("\\n", "\n");
                        datalist.Add(clinicalnotes);
                    }

                 // Return the list of ClinicalNotes
                return datalist;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                // Return an empty list if an error occurs
                return new List<ClinicalNotes>();
            }
        }

        // Save the entire list of clinical notes to the data file
        public void SaveallData(List<ClinicalNotes> datalist)
        {
            try
            {
                // Delete the existing data file
                DeletAllData();

                using (var documentFile = File.Open("AllEncounterNotes.txt", FileMode.Create))
                {
                    using var textWriter = new StreamWriter(documentFile);

                    // Iterate through the list and convert each ClinicalNotes object to text
                    foreach (var note in datalist)
                    {
                        string formattedNote = note.ConvertToTextFile();

                        // Write formatted data to the file
                        textWriter.WriteLine(formattedNote);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while saving notes: {e.Message}");
            }
        }
    }
}
