namespace OverSurgery2.UserInterface
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
            this.perscriptionDate = new System.Windows.Forms.ListBox();
            this.PrescriptionMed = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // perscriptionDate
            // 
            this.perscriptionDate.FormattingEnabled = true;
            this.perscriptionDate.Location = new System.Drawing.Point(23, 588);
            this.perscriptionDate.Name = "perscriptionDate";
            this.perscriptionDate.Size = new System.Drawing.Size(132, 238);
            this.perscriptionDate.TabIndex = 0;
            this.perscriptionDate.SelectedIndexChanged += new System.EventHandler(this.medHDate_SelectedIndexChanged);
            // 
            // PrescriptionMed
            // 
            this.PrescriptionMed.FormattingEnabled = true;
            this.PrescriptionMed.Location = new System.Drawing.Point(161, 588);
            this.PrescriptionMed.Name = "PrescriptionMed";
            this.PrescriptionMed.Size = new System.Drawing.Size(132, 238);
            this.PrescriptionMed.TabIndex = 1;
            this.PrescriptionMed.SelectedIndexChanged += new System.EventHandler(this.medHSymtom_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 487);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 95);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(299, 588);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 238);
            this.listBox2.TabIndex = 4;
            // 
            // MedicalStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 838);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrescriptionMed);
            this.Controls.Add(this.perscriptionDate);
            this.Name = "MedicalStaff";
            this.Text = "MedicalStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox perscriptionDate;
        private System.Windows.Forms.ListBox PrescriptionMed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}