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
            this.lst_Medication = new System.Windows.Forms.ListBox();
            this.txt_prescriptionNotes = new System.Windows.Forms.TextBox();
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_savePrescription = new System.Windows.Forms.Button();
            this.lb_medication = new System.Windows.Forms.Label();
            this.lb_notes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Medication
            // 
            this.lst_Medication.FormattingEnabled = true;
            this.lst_Medication.Location = new System.Drawing.Point(16, 82);
            this.lst_Medication.Name = "lst_Medication";
            this.lst_Medication.Size = new System.Drawing.Size(275, 121);
            this.lst_Medication.TabIndex = 0;
            // 
            // txt_prescriptionNotes
            // 
            this.txt_prescriptionNotes.Location = new System.Drawing.Point(297, 82);
            this.txt_prescriptionNotes.Multiline = true;
            this.txt_prescriptionNotes.Name = "txt_prescriptionNotes";
            this.txt_prescriptionNotes.Size = new System.Drawing.Size(317, 121);
            this.txt_prescriptionNotes.TabIndex = 1;
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(12, 9);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(132, 20);
            this.lb_patient.TabIndex = 2;
            this.lb_patient.Text = "Prescription For : ";
            this.lb_patient.Click += new System.EventHandler(this.lb_patient_Click);
            // 
            // btn_savePrescription
            // 
            this.btn_savePrescription.Location = new System.Drawing.Point(472, 209);
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
            this.lb_medication.Location = new System.Drawing.Point(13, 43);
            this.lb_medication.Name = "lb_medication";
            this.lb_medication.Size = new System.Drawing.Size(59, 13);
            this.lb_medication.TabIndex = 4;
            this.lb_medication.Text = "Medication";
            // 
            // lb_notes
            // 
            this.lb_notes.AutoSize = true;
            this.lb_notes.Location = new System.Drawing.Point(297, 66);
            this.lb_notes.Name = "lb_notes";
            this.lb_notes.Size = new System.Drawing.Size(93, 13);
            this.lb_notes.TabIndex = 5;
            this.lb_notes.Text = "Prescription Notes";
            this.lb_notes.Click += new System.EventHandler(this.lb_notes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(220, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_notes);
            this.Controls.Add(this.lb_medication);
            this.Controls.Add(this.btn_savePrescription);
            this.Controls.Add(this.lb_patient);
            this.Controls.Add(this.txt_prescriptionNotes);
            this.Controls.Add(this.lst_Medication);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Medication;
        private System.Windows.Forms.TextBox txt_prescriptionNotes;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_savePrescription;
        private System.Windows.Forms.Label lb_medication;
        private System.Windows.Forms.Label lb_notes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}