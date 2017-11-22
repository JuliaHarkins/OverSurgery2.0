namespace OverSurgery2
{
    partial class AddPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_prescriptionNotes = new System.Windows.Forms.TextBox();
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_savePrescription = new System.Windows.Forms.Button();
            this.lb_medication = new System.Windows.Forms.Label();
            this.lb_notes = new System.Windows.Forms.Label();
            this.btn_medicationSearch = new System.Windows.Forms.Button();
            this.txt_medicationSearch = new System.Windows.Forms.TextBox();
            this.lst_medication = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txt_prescriptionNotes
            // 
            this.txt_prescriptionNotes.Location = new System.Drawing.Point(268, 101);
            this.txt_prescriptionNotes.Multiline = true;
            this.txt_prescriptionNotes.Name = "txt_prescriptionNotes";
            this.txt_prescriptionNotes.Size = new System.Drawing.Size(342, 111);
            this.txt_prescriptionNotes.TabIndex = 1;
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(53, 21);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(132, 20);
            this.lb_patient.TabIndex = 2;
            this.lb_patient.Text = "Prescription For : ";
            // 
            // btn_savePrescription
            // 
            this.btn_savePrescription.Location = new System.Drawing.Point(468, 218);
            this.btn_savePrescription.Name = "btn_savePrescription";
            this.btn_savePrescription.Size = new System.Drawing.Size(142, 23);
            this.btn_savePrescription.TabIndex = 3;
            this.btn_savePrescription.Text = "Save Prescription";
            this.btn_savePrescription.UseVisualStyleBackColor = true;
            this.btn_savePrescription.Click += new System.EventHandler(this.btn_savePrescription_Click);
            // 
            // lb_medication
            // 
            this.lb_medication.AutoSize = true;
            this.lb_medication.Location = new System.Drawing.Point(13, 59);
            this.lb_medication.Name = "lb_medication";
            this.lb_medication.Size = new System.Drawing.Size(59, 13);
            this.lb_medication.TabIndex = 4;
            this.lb_medication.Text = "Medication";
            // 
            // lb_notes
            // 
            this.lb_notes.AutoSize = true;
            this.lb_notes.Location = new System.Drawing.Point(278, 85);
            this.lb_notes.Name = "lb_notes";
            this.lb_notes.Size = new System.Drawing.Size(93, 13);
            this.lb_notes.TabIndex = 5;
            this.lb_notes.Text = "Prescription Notes";
            // 
            // btn_medicationSearch
            // 
            this.btn_medicationSearch.Location = new System.Drawing.Point(187, 73);
            this.btn_medicationSearch.Name = "btn_medicationSearch";
            this.btn_medicationSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_medicationSearch.TabIndex = 6;
            this.btn_medicationSearch.Text = "Search";
            this.btn_medicationSearch.UseVisualStyleBackColor = true;
            this.btn_medicationSearch.Click += new System.EventHandler(this.btn_medicationSearch_Click);
            // 
            // txt_medicationSearch
            // 
            this.txt_medicationSearch.Location = new System.Drawing.Point(16, 75);
            this.txt_medicationSearch.Name = "txt_medicationSearch";
            this.txt_medicationSearch.Size = new System.Drawing.Size(169, 20);
            this.txt_medicationSearch.TabIndex = 7;
            // 
            // lst_medication
            // 
            this.lst_medication.Location = new System.Drawing.Point(16, 102);
            this.lst_medication.Name = "lst_medication";
            this.lst_medication.Size = new System.Drawing.Size(246, 110);
            this.lst_medication.TabIndex = 8;
            this.lst_medication.UseCompatibleStateImageBehavior = false;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 249);
            this.Controls.Add(this.lst_medication);
            this.Controls.Add(this.txt_medicationSearch);
            this.Controls.Add(this.btn_medicationSearch);
            this.Controls.Add(this.lb_notes);
            this.Controls.Add(this.lb_medication);
            this.Controls.Add(this.btn_savePrescription);
            this.Controls.Add(this.lb_patient);
            this.Controls.Add(this.txt_prescriptionNotes);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.btn_savePrescription_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_prescriptionNotes;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_savePrescription;
        private System.Windows.Forms.Label lb_medication;
        private System.Windows.Forms.Label lb_notes;
        private System.Windows.Forms.Button btn_medicationSearch;
        private System.Windows.Forms.TextBox txt_medicationSearch;
        private System.Windows.Forms.ListView lst_medication;
    }
}