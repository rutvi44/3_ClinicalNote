

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalNote
{
    // Manages the collection of clinical notes
    public class ManagerClinicalNotes
    {
        // Handles file operations
        private readonly AllData allFileData;

        // Stores clinical notes
        private readonly List<ClinicalNotes> clinicalNotesList = new();

        // Constructor to initialize the ManagerClinicalNotes instance
        public ManagerClinicalNotes()
        {
            allFileData = new AllData();
            clinicalNotesList = allFileData.GetAllData();
        }

        // Removes a clinical note from the collection and updates the data file
        public void DeleteNotes(ClinicalNotes notes)
        {
            clinicalNotesList.Remove(notes);
            allFileData.SaveallData(clinicalNotesList);
        }

        // Returns the next available ID for a new clinical note
        public int NextAvailableID()
        {
            return clinicalNotesList.Count + 1;
        }

        // Edits an existing clinical note and updates the data file
        public void EditNotes(ClinicalNotes notes)
        {
            var updatednptes = clinicalNotesList.FindIndex(n => n.NoteID == notes.NoteID);
            clinicalNotesList[updatednptes] = notes;
            allFileData.SaveallData(clinicalNotesList);
        }

        // Sets the collection of clinical notes
        public void SetNoteList(List<ClinicalNotes> notes)
        {
            clinicalNotesList.Clear();
            clinicalNotesList.AddRange(notes);
        }

        // Adds a new clinical note to the collection and updates the data file
        public void AddNotes(ClinicalNotes notes)
        {
            clinicalNotesList.Add(notes);
            allFileData.SaveallData(clinicalNotesList);
        }

        // Retrieves all clinical notes from the collection
        public List<ClinicalNotes> GetAllData()
        {
            return clinicalNotesList;
        }

    }
}
