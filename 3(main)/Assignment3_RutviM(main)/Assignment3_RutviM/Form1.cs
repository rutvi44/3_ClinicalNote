

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using ClinicalNote;
using System.Diagnostics.Metrics;

namespace Assignment3_RutviM
{
    public partial class Form1 : Form
    {
        // Represents the main form of the application
        private ManagerClinicalNotes clinicalnoteslist;

        public Form1()
        {
            InitializeComponent();
            
            // Stores the instance of ManagerClinicalNotes to manage clinical notes
            clinicalnoteslist = new ManagerClinicalNotes();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the initial state of the form and update the notes list box
            SetStartingState();
            UpdateNotesListBox();
        }

        // Sets the initial state of the form
        private void SetStartingState()
        {
            // Clear all input fields, disable certain buttons and inputs, and reset error labels
            AllInputClear();
            SetAllButtons(false);
            SetAllInput(false);
            lblError.Text = "";
        }

        // Updates the notes list box with data from the clinical notes list
        private void UpdateNotesListBox()
        {
            // Clear the notes list box and populate it with clinical notes
            lstClinicalNote.Items.Clear();
            foreach (var notes in clinicalnoteslist.GetAllData())
            {
                lstClinicalNote.Items.Add(notes);
            }
        }

        // Sets the enabled state of various buttons
        private void SetAllButtons(bool position)
        {
            // Enable or disable buttons based on the given position
            btnAdd.Enabled = position;
            btnAdd.Enabled = position;
            btnUpdate.Enabled = position;
            btnDelete.Enabled = position;
            btnRemoveProblems.Enabled = position;
        }

        // Sets the enabled state of various input field
        private void SetAllInput(bool position)
        {
            // Enable or disable input fields based on the given position
            txtPatientName.Enabled = position;
            txtProblem.Enabled = position;
            rtbNotes.Enabled = position;
            dateTimePicker1.Enabled = position;
        }

        // Clears all input fields and resets the date picker
        private void AllInputClear()
        {
            txtNoteID.Text = "";
            txtPatientName.Text = "";
            txtProblem.Text = "";
            rtbNotes.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            lstClinicalNote.SelectedIndex = -1;
            lstProblems.Items.Clear();
            lstVitals.Items.Clear();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Updates elements with data from the selected ClinicalNotes object
        private void UpdateNotesListBox(ClinicalNotes notes)
        {
            txtNoteID.Text = notes.NoteID.ToString();
            txtPatientName.Text = notes.PatientName;
            rtbNotes.Text = notes.ContentOfNotes;
            dateTimePicker1.Value = notes.DateOfBirth;

            // Clear and populate the Problems list box and Vitals list box
            lstProblems.Items.Clear();
            foreach (var problem in notes.Problems)
            {
                lstProblems.Items.Add(problem);
            }

            lstVitals.Items.Clear();
            foreach (var vitals in notes.counting)
            {
                lstVitals.Items.Add(vitals);
            }
        }

        // Event handler for the "Start New" button click
        private void btnStartNew_Click(object sender, EventArgs e)
        {
            // Clear input fields, set NoteID, and enable relevant buttons and inputs
            AllInputClear();
            txtNoteID.Text = clinicalnoteslist.NextAvailableID().ToString();
            SetAllInput(true);
            SetAllButtons(false);
            btnAddNote.Enabled = true;
            btnAdd.Enabled = true;
        }

        // Event handler for the "Add Note" button click
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            // Validate fields, create ClinicalNotes object, add to list, and update UI
            if (!FieldsValidated()) return;

            var notes = new ClinicalNotes(
                int.Parse(txtNoteID.Text),
                txtPatientName.Text,
                dateTimePicker1.Value,
                rtbNotes.Text
                );

            AddVitalsAndProblems(notes);
            clinicalnoteslist.AddNotes(notes);

            SetStartingState();
            UpdateNotesListBox();
            lblMessage.Text = @"Data Succefully added in record.";
            lblMessage.Enabled = true;
            lblError.Text = "";
            lblError.Enabled = true;
        }

        // Validates input fields and displays error messages
        private bool FieldsValidated()
        {
            var errormessages = new List<string>();

            // Validate patient name field
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                errormessages.Add("Patient name require");
            }

            // Validate problems list
            if (lstProblems.Items.Count == 0)
            {
                errormessages.Add("At least One problem Required");
            }

            // Validate notes field
            if (string.IsNullOrEmpty(rtbNotes.Text))
            {
                errormessages.Add("Notes Required");
            }

            // Validate date of birth
            if (dateTimePicker1.Value > DateTime.Now)
            {
                errormessages.Add("Future Date of Birth is not acceptable");
            }

            // Display error messages or return true if validation passes
            if (errormessages.Count <= 0)
            {
                return true;
            }

            lblError.Text = string.Join("\n", errormessages);
            lblMessage.Text = "";
            return false;
        }

        // Adds problems and vitals to a ClinicalNotes object
        private void AddVitalsAndProblems(ClinicalNotes notes)
        {
            foreach (var data in lstProblems.Items)
            {
                if (data is string problems)
                {
                    notes.Problems.Add(problems);
                }
            }
            foreach (var data in lstVitals.Items)
            {
                if (data is string vitals)
                {
                    notes.counting.Add(vitals);
                }
            }
        }

        // Event handler for the "Remove Problems" button click
        private void btnRemoveProblems_Click(object sender, EventArgs e)
        {
            // Remove the selected problem from the list box
            var selectedProblem = lstProblems.SelectedItem;

            if (selectedProblem == null)
            {
                lblError.Text = "Select a problem which you want to remove!";
                return;
            }

            lstProblems.Items.Remove(selectedProblem);
        }

        // Event handler for when an item in the clinical notes list box is selected
        private void lstClinicalNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClinicalNote.SelectedItem is ClinicalNotes notes)
            {
                UpdateNotesListBox(notes);
                SetAllInput(true);
                btnAddNote.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnRemoveProblems.Enabled = true;
            }
        }

        // Event handler for the "Update" button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate fields, update ClinicalNotes object, update list, and UI
            if (!FieldsValidated())
                return;

            var allnotes = new ClinicalNotes(
                int.Parse(txtNoteID.Text),
                txtPatientName.Text,
                dateTimePicker1.Value,
                rtbNotes.Text
            );

            AddVitalsAndProblems(allnotes);
            clinicalnoteslist.EditNotes(allnotes);

            SetStartingState();
            UpdateNotesListBox();

            lblMessage.Text = "Note Succefully Updated!!";
            lblError.Text = "";
        }

        // Event handler for the "Delete" button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected note and update the UI
            var selectedNote = lstClinicalNote.SelectedItem as ClinicalNotes;

            if (selectedNote == null)
            {
                lblError.Text = "Please select a note which you want to delete";
                return;
            }

            clinicalnoteslist.DeleteNotes(selectedNote);
            SetStartingState();
            UpdateNotesListBox();
            lblMessage.Text = "Selected Note deleted Successfully!!";
            lblError.Text = "";
        }

        // Event handler for when the notes text box content changes
        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            // Update vitals list box based on the notes content
            if (string.IsNullOrEmpty(rtbNotes.Text))
            {
                lblError.Text = "Note is required";
                return;
            }

            var allVitals = Vitals.GetVitals(rtbNotes.Text);
            lstVitals.Items.Clear();
            foreach (var vital in allVitals)
            {
                lstVitals.Items.Add(vital);
            }
        }

        // Event handler for the "Add" button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a problem to the problems list box
            var allProblems = txtProblem.Text;

            if (string.IsNullOrEmpty(allProblems))
            {
                lblError.Text = "Atleast one problem required";
                lblMessage.Text = "";
                return;
            }

            lstProblems.Items.Add(allProblems);
            txtProblem.Text = "";
        }
    }
}