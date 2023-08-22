namespace Assignment3_RutviM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartNew = new Button();
            lstClinicalNote = new ListBox();
            groupBox1 = new GroupBox();
            btnRemoveProblems = new Button();
            label7 = new Label();
            label6 = new Label();
            lstVitals = new ListBox();
            lstProblems = new ListBox();
            btnAdd = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtProblem = new TextBox();
            txtPatientName = new TextBox();
            txtNoteID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAddNote = new Button();
            label1 = new Label();
            rtbNotes = new RichTextBox();
            lblError = new Label();
            lblMessage = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartNew
            // 
            btnStartNew.BackColor = SystemColors.GradientActiveCaption;
            btnStartNew.Location = new Point(43, 39);
            btnStartNew.Margin = new Padding(4, 3, 4, 3);
            btnStartNew.Name = "btnStartNew";
            btnStartNew.Size = new Size(284, 60);
            btnStartNew.TabIndex = 0;
            btnStartNew.Text = "Start New";
            btnStartNew.UseVisualStyleBackColor = false;
            btnStartNew.Click += btnStartNew_Click;
            // 
            // lstClinicalNote
            // 
            lstClinicalNote.FormattingEnabled = true;
            lstClinicalNote.ItemHeight = 17;
            lstClinicalNote.Location = new Point(38, 137);
            lstClinicalNote.Margin = new Padding(4, 3, 4, 3);
            lstClinicalNote.Name = "lstClinicalNote";
            lstClinicalNote.Size = new Size(288, 803);
            lstClinicalNote.TabIndex = 1;
            lstClinicalNote.SelectedIndexChanged += lstClinicalNote_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemoveProblems);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lstVitals);
            groupBox1.Controls.Add(lstProblems);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtProblem);
            groupBox1.Controls.Add(txtPatientName);
            groupBox1.Controls.Add(txtNoteID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAddNote);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rtbNotes);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(353, 39);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1356, 912);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edit/Delete/Encounter Note:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnRemoveProblems
            // 
            btnRemoveProblems.BackColor = SystemColors.GradientActiveCaption;
            btnRemoveProblems.Location = new Point(611, 372);
            btnRemoveProblems.Name = "btnRemoveProblems";
            btnRemoveProblems.Size = new Size(286, 50);
            btnRemoveProblems.TabIndex = 18;
            btnRemoveProblems.Text = "Remove Problems";
            btnRemoveProblems.UseVisualStyleBackColor = false;
            btnRemoveProblems.Click += btnRemoveProblems_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(972, 35);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 17;
            label7.Text = "Vitals:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 35);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 16;
            label6.Text = "Problems:";
            // 
            // lstVitals
            // 
            lstVitals.FormattingEnabled = true;
            lstVitals.ItemHeight = 15;
            lstVitals.Location = new Point(972, 77);
            lstVitals.Name = "lstVitals";
            lstVitals.Size = new Size(344, 349);
            lstVitals.TabIndex = 15;
            lstVitals.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // lstProblems
            // 
            lstProblems.FormattingEnabled = true;
            lstProblems.ItemHeight = 15;
            lstProblems.Location = new Point(611, 77);
            lstProblems.Name = "lstProblems";
            lstProblems.Size = new Size(286, 274);
            lstProblems.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Location = new Point(272, 393);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(198, 49);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(204, 261);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(206, 345);
            txtProblem.Margin = new Padding(4, 3, 4, 3);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(263, 23);
            txtProblem.TabIndex = 11;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(204, 177);
            txtPatientName.Margin = new Padding(4, 3, 4, 3);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(263, 23);
            txtPatientName.TabIndex = 10;
            // 
            // txtNoteID
            // 
            txtNoteID.Location = new Point(204, 89);
            txtNoteID.Margin = new Padding(4, 3, 4, 3);
            txtNoteID.Name = "txtNoteID";
            txtNoteID.Size = new Size(263, 23);
            txtNoteID.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 348);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 8;
            label5.Text = "New Problem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Date Of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "Patient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Note ID:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Location = new Point(257, 854);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 41);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Note";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Location = new Point(535, 854);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Note";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = SystemColors.GradientActiveCaption;
            btnAddNote.Location = new Point(34, 854);
            btnAddNote.Margin = new Padding(4, 3, 4, 3);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(142, 41);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 440);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Notes:";
            // 
            // rtbNotes
            // 
            rtbNotes.Location = new Point(19, 489);
            rtbNotes.Margin = new Padding(4, 3, 4, 3);
            rtbNotes.Name = "rtbNotes";
            rtbNotes.Size = new Size(1297, 334);
            rtbNotes.TabIndex = 0;
            rtbNotes.Text = "";
            rtbNotes.TextChanged += rtbNotes_TextChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(43, 974);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(52, 21);
            lblError.TabIndex = 3;
            lblError.Text = "label2";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(40, 997);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 19);
            lblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1737, 1033);
            Controls.Add(lblMessage);
            Controls.Add(lblError);
            Controls.Add(groupBox1);
            Controls.Add(lstClinicalNote);
            Controls.Add(btnStartNew);
            Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartNew;
        private ListBox lstClinicalNote;
        private GroupBox groupBox1;
        private RichTextBox rtbNotes;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAddNote;
        private Label lblError;
        private TextBox txtProblem;
        private TextBox txtPatientName;
        private TextBox txtNoteID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private ListBox lstVitals;
        private ListBox lstProblems;
        private Label label7;
        private Label label6;
        private Button btnRemoveProblems;
        private Label lblMessage;
    }
}