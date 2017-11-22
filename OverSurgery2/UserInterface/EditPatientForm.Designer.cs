namespace OverSurgery2
{
    partial class EditPatientForm
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
            this.txt_Forename = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Forename
            // 
            this.txt_Forename.Location = new System.Drawing.Point(75, 12);
            this.txt_Forename.Name = "txt_Forename";
            this.txt_Forename.Size = new System.Drawing.Size(100, 20);
            this.txt_Forename.TabIndex = 0;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(75, 38);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 20);
            this.txt_Surname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Patient";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(12, 15);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(57, 13);
            this.lbl_Forename.TabIndex = 3;
            this.lbl_Forename.Text = "First Name";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 41);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(58, 13);
            this.lbl_Surname.TabIndex = 4;
            this.lbl_Surname.Text = "Last Name";
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 411);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Forename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Forename);
            this.Name = "EditPatientForm";
            this.Text = "EditPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Forename;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_Surname;
    }
}