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
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_savePrescription = new System.Windows.Forms.Button();
            this.lb_medication = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.btn_medicationSearch = new System.Windows.Forms.Button();
            this.txt_medicationSearch = new System.Windows.Forms.TextBox();
            this.lst_medication = new System.Windows.Forms.ListView();
            this.mc_ = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_dateOfNextIssue = new System.Windows.Forms.CheckBox();
            this.lb_dateOfNextIssue = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(24, 18);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(132, 20);
            this.lb_patient.TabIndex = 2;
            this.lb_patient.Text = "Prescription For : ";
            // 
            // btn_savePrescription
            // 
            this.btn_savePrescription.Location = new System.Drawing.Point(375, 373);
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
            this.lb_medication.Location = new System.Drawing.Point(25, 50);
            this.lb_medication.Name = "lb_medication";
            this.lb_medication.Size = new System.Drawing.Size(59, 13);
            this.lb_medication.TabIndex = 4;
            this.lb_medication.Text = "Medication";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(287, 263);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(101, 13);
            this.lb_amount.TabIndex = 5;
            this.lb_amount.Text = "Prescription Amount";
            this.lb_amount.Click += new System.EventHandler(this.lb_notes_Click);
            // 
            // btn_medicationSearch
            // 
            this.btn_medicationSearch.Location = new System.Drawing.Point(203, 64);
            this.btn_medicationSearch.Name = "btn_medicationSearch";
            this.btn_medicationSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_medicationSearch.TabIndex = 6;
            this.btn_medicationSearch.Text = "Search";
            this.btn_medicationSearch.UseVisualStyleBackColor = true;
            this.btn_medicationSearch.Click += new System.EventHandler(this.btn_medicationSearch_Click);
            // 
            // txt_medicationSearch
            // 
            this.txt_medicationSearch.Location = new System.Drawing.Point(28, 66);
            this.txt_medicationSearch.Name = "txt_medicationSearch";
            this.txt_medicationSearch.Size = new System.Drawing.Size(169, 20);
            this.txt_medicationSearch.TabIndex = 7;
            // 
            // lst_medication
            // 
            this.lst_medication.Location = new System.Drawing.Point(28, 92);
            this.lst_medication.Name = "lst_medication";
            this.lst_medication.Size = new System.Drawing.Size(250, 304);
            this.lst_medication.TabIndex = 8;
            this.lst_medication.UseCompatibleStateImageBehavior = false;
            this.lst_medication.View = System.Windows.Forms.View.Details;
            // 
            // mc_
            // 
            this.mc_.Location = new System.Drawing.Point(290, 92);
            this.mc_.Name = "mc_";
            this.mc_.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cb_dateOfNextIssue
            // 
            this.cb_dateOfNextIssue.AutoSize = true;
            this.cb_dateOfNextIssue.Location = new System.Drawing.Point(290, 298);
            this.cb_dateOfNextIssue.Name = "cb_dateOfNextIssue";
            this.cb_dateOfNextIssue.Size = new System.Drawing.Size(73, 17);
            this.cb_dateOfNextIssue.TabIndex = 14;
            this.cb_dateOfNextIssue.Text = "Extenable";
            this.cb_dateOfNextIssue.UseVisualStyleBackColor = true;
            // 
            // lb_dateOfNextIssue
            // 
            this.lb_dateOfNextIssue.AutoSize = true;
            this.lb_dateOfNextIssue.Location = new System.Drawing.Point(287, 318);
            this.lb_dateOfNextIssue.Name = "lb_dateOfNextIssue";
            this.lb_dateOfNextIssue.Size = new System.Drawing.Size(97, 13);
            this.lb_dateOfNextIssue.TabIndex = 15;
            this.lb_dateOfNextIssue.Text = "Date Of Next Issue";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(394, 261);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(123, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 414);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lb_dateOfNextIssue);
            this.Controls.Add(this.cb_dateOfNextIssue);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mc_);
            this.Controls.Add(this.lst_medication);
            this.Controls.Add(this.txt_medicationSearch);
            this.Controls.Add(this.btn_medicationSearch);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.lb_medication);
            this.Controls.Add(this.btn_savePrescription);
            this.Controls.Add(this.lb_patient);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_savePrescription;
        private System.Windows.Forms.Label lb_medication;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Button btn_medicationSearch;
        private System.Windows.Forms.TextBox txt_medicationSearch;
        private System.Windows.Forms.ListView lst_medication;
        private System.Windows.Forms.MonthCalendar mc_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cb_dateOfNextIssue;
        private System.Windows.Forms.Label lb_dateOfNextIssue;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}