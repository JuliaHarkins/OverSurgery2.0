namespace OverSurgery2
{
    partial class PrescriptionExtendDialog
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
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.btn_Extend = new System.Windows.Forms.Button();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MedicationText = new System.Windows.Forms.Label();
            this.lbl_Patient = new System.Windows.Forms.Label();
            this.lbl_PatientText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(12, 72);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(348, 26);
            this.txt_Reason.TabIndex = 2;
            // 
            // btn_Extend
            // 
            this.btn_Extend.Location = new System.Drawing.Point(204, 106);
            this.btn_Extend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Extend.Name = "btn_Extend";
            this.btn_Extend.Size = new System.Drawing.Size(156, 35);
            this.btn_Extend.TabIndex = 1;
            this.btn_Extend.Text = "Request Extension";
            this.btn_Extend.UseVisualStyleBackColor = true;
            this.btn_Extend.Click += new System.EventHandler(this.btn_Extend_Click);
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Location = new System.Drawing.Point(12, 49);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(164, 20);
            this.lbl_Reason.TabIndex = 3;
            this.lbl_Reason.Text = "Reason for extension:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medication:";
            // 
            // lbl_MedicationText
            // 
            this.lbl_MedicationText.AutoSize = true;
            this.lbl_MedicationText.Location = new System.Drawing.Point(108, 29);
            this.lbl_MedicationText.Name = "lbl_MedicationText";
            this.lbl_MedicationText.Size = new System.Drawing.Size(171, 20);
            this.lbl_MedicationText.TabIndex = 5;
            this.lbl_MedicationText.Text = "Medication Name Here";
            // 
            // lbl_Patient
            // 
            this.lbl_Patient.AutoSize = true;
            this.lbl_Patient.Location = new System.Drawing.Point(12, 9);
            this.lbl_Patient.Name = "lbl_Patient";
            this.lbl_Patient.Size = new System.Drawing.Size(63, 20);
            this.lbl_Patient.TabIndex = 6;
            this.lbl_Patient.Text = "Patient:";
            // 
            // lbl_PatientText
            // 
            this.lbl_PatientText.AutoSize = true;
            this.lbl_PatientText.Location = new System.Drawing.Point(81, 9);
            this.lbl_PatientText.Name = "lbl_PatientText";
            this.lbl_PatientText.Size = new System.Drawing.Size(144, 20);
            this.lbl_PatientText.TabIndex = 7;
            this.lbl_PatientText.Text = "Patient Name Here";
            // 
            // PrescriptionExtendDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 148);
            this.Controls.Add(this.lbl_PatientText);
            this.Controls.Add(this.lbl_Patient);
            this.Controls.Add(this.lbl_MedicationText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Reason);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.btn_Extend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrescriptionExtendDialog";
            this.Text = "Extend Prescription";
            this.Load += new System.EventHandler(this.PrescriptionExtendDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Button btn_Extend;
        private System.Windows.Forms.Label lbl_Reason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MedicationText;
        private System.Windows.Forms.Label lbl_Patient;
        private System.Windows.Forms.Label lbl_PatientText;
    }
}