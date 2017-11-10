namespace OverSurgery2
{
    partial class ViewPatientInfoForm
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
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_EditPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(12, 9);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(23, 13);
            this.lbl_Forename.TabIndex = 0;
            this.lbl_Forename.Text = "null";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 58);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(23, 13);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "null";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 84);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(23, 13);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "null";
            // 
            // btn_EditPatient
            // 
            this.btn_EditPatient.Location = new System.Drawing.Point(15, 226);
            this.btn_EditPatient.Name = "btn_EditPatient";
            this.btn_EditPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPatient.TabIndex = 3;
            this.btn_EditPatient.Text = "Edit Patient";
            this.btn_EditPatient.UseVisualStyleBackColor = true;
            this.btn_EditPatient.Click += new System.EventHandler(this.btn_EditPatient_Click);
            // 
            // ViewPatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.btn_EditPatient);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Forename);
            this.Name = "ViewPatientInfoForm";
            this.Text = "ViewPatientInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_EditPatient;
    }
}