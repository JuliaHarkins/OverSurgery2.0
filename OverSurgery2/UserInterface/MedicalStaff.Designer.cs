﻿namespace OverSurgery2.UserInterface
{
    partial class MedicalStaff
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
            this.txt_CurrentNotes = new System.Windows.Forms.ListBox();
            this.dgv_medicalHistory = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_appnotes = new System.Windows.Forms.Label();
            this.btn_addPerscription = new System.Windows.Forms.Button();
            this.btn_saveNotes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientForname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nextPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_appList = new System.Windows.Forms.Label();
            this.lb_MedHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CurrentNotes
            // 
            this.txt_CurrentNotes.FormattingEnabled = true;
            this.txt_CurrentNotes.Location = new System.Drawing.Point(12, 318);
            this.txt_CurrentNotes.Name = "txt_CurrentNotes";
            this.txt_CurrentNotes.Size = new System.Drawing.Size(830, 160);
            this.txt_CurrentNotes.TabIndex = 3;
            // 
            // dgv_medicalHistory
            // 
            this.dgv_medicalHistory.AllowUserToAddRows = false;
            this.dgv_medicalHistory.AllowUserToDeleteRows = false;
            this.dgv_medicalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_medicalHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_medicalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.notes,
            this.prescriptions});
            this.dgv_medicalHistory.Location = new System.Drawing.Point(12, 497);
            this.dgv_medicalHistory.Name = "dgv_medicalHistory";
            this.dgv_medicalHistory.ReadOnly = true;
            this.dgv_medicalHistory.Size = new System.Drawing.Size(960, 280);
            this.dgv_medicalHistory.TabIndex = 8;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 55;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 60;
            // 
            // prescriptions
            // 
            this.prescriptions.HeaderText = "Prescriptions";
            this.prescriptions.Name = "prescriptions";
            this.prescriptions.ReadOnly = true;
            this.prescriptions.Width = 92;
            // 
            // lb_appnotes
            // 
            this.lb_appnotes.AutoSize = true;
            this.lb_appnotes.Location = new System.Drawing.Point(9, 299);
            this.lb_appnotes.Name = "lb_appnotes";
            this.lb_appnotes.Size = new System.Drawing.Size(97, 13);
            this.lb_appnotes.TabIndex = 9;
            this.lb_appnotes.Text = "Appointment Notes";
            this.lb_appnotes.Click += new System.EventHandler(this.lb_notes_Click);
            // 
            // btn_addPerscription
            // 
            this.btn_addPerscription.Location = new System.Drawing.Point(848, 424);
            this.btn_addPerscription.Name = "btn_addPerscription";
            this.btn_addPerscription.Size = new System.Drawing.Size(124, 25);
            this.btn_addPerscription.TabIndex = 10;
            this.btn_addPerscription.Text = "Add Perscription";
            this.btn_addPerscription.UseVisualStyleBackColor = true;
            this.btn_addPerscription.Click += new System.EventHandler(this.btn_addPerscription_Click);
            // 
            // btn_saveNotes
            // 
            this.btn_saveNotes.Location = new System.Drawing.Point(848, 453);
            this.btn_saveNotes.Name = "btn_saveNotes";
            this.btn_saveNotes.Size = new System.Drawing.Size(124, 25);
            this.btn_saveNotes.TabIndex = 11;
            this.btn_saveNotes.Text = "Save Notes";
            this.btn_saveNotes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appTime,
            this.patientForname,
            this.patientLastName,
            this.appNotes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(830, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // appTime
            // 
            this.appTime.HeaderText = "Time";
            this.appTime.Name = "appTime";
            this.appTime.ReadOnly = true;
            this.appTime.Width = 55;
            // 
            // patientForname
            // 
            this.patientForname.HeaderText = "Forname";
            this.patientForname.Name = "patientForname";
            this.patientForname.ReadOnly = true;
            this.patientForname.Width = 73;
            // 
            // patientLastName
            // 
            this.patientLastName.HeaderText = "Surname";
            this.patientLastName.Name = "patientLastName";
            this.patientLastName.ReadOnly = true;
            this.patientLastName.Width = 74;
            // 
            // appNotes
            // 
            this.appNotes.HeaderText = "Notes";
            this.appNotes.Name = "appNotes";
            this.appNotes.ReadOnly = true;
            this.appNotes.Width = 60;
            // 
            // btn_nextPatient
            // 
            this.btn_nextPatient.Location = new System.Drawing.Point(848, 271);
            this.btn_nextPatient.Name = "btn_nextPatient";
            this.btn_nextPatient.Size = new System.Drawing.Size(126, 25);
            this.btn_nextPatient.TabIndex = 13;
            this.btn_nextPatient.Text = "Next Patient";
            this.btn_nextPatient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(868, 793);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log Off";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_appList
            // 
            this.lb_appList.AutoSize = true;
            this.lb_appList.Location = new System.Drawing.Point(12, 130);
            this.lb_appList.Name = "lb_appList";
            this.lb_appList.Size = new System.Drawing.Size(85, 13);
            this.lb_appList.TabIndex = 15;
            this.lb_appList.Text = "Appointment List";
            // 
            // lb_MedHistory
            // 
            this.lb_MedHistory.AutoSize = true;
            this.lb_MedHistory.Location = new System.Drawing.Point(9, 481);
            this.lb_MedHistory.Name = "lb_MedHistory";
            this.lb_MedHistory.Size = new System.Drawing.Size(79, 13);
            this.lb_MedHistory.TabIndex = 16;
            this.lb_MedHistory.Text = "Medical History";
            // 
            // MedicalStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 838);
            this.Controls.Add(this.lb_MedHistory);
            this.Controls.Add(this.lb_appList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nextPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_saveNotes);
            this.Controls.Add(this.btn_addPerscription);
            this.Controls.Add(this.lb_appnotes);
            this.Controls.Add(this.dgv_medicalHistory);
            this.Controls.Add(this.txt_CurrentNotes);
            this.Name = "MedicalStaff";
            this.Text = "MedicalStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox txt_CurrentNotes;
        private System.Windows.Forms.DataGridView dgv_medicalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptions;
        private System.Windows.Forms.Label lb_appnotes;
        private System.Windows.Forms.Button btn_addPerscription;
        private System.Windows.Forms.Button btn_saveNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientForname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNotes;
        private System.Windows.Forms.Button btn_nextPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_appList;
        private System.Windows.Forms.Label lb_MedHistory;
    }
}