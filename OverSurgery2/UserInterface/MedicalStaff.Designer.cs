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
            this.medHDate = new System.Windows.Forms.ListBox();
            this.medHSymtom = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // medHDate
            // 
            this.medHDate.FormattingEnabled = true;
            this.medHDate.Location = new System.Drawing.Point(37, 427);
            this.medHDate.Name = "medHDate";
            this.medHDate.Size = new System.Drawing.Size(132, 238);
            this.medHDate.TabIndex = 0;
            // 
            // medHSymtom
            // 
            this.medHSymtom.FormattingEnabled = true;
            this.medHSymtom.Location = new System.Drawing.Point(175, 427);
            this.medHSymtom.Name = "medHSymtom";
            this.medHSymtom.Size = new System.Drawing.Size(132, 238);
            this.medHSymtom.TabIndex = 1;
            this.medHSymtom.SelectedIndexChanged += new System.EventHandler(this.medHSymtom_SelectedIndexChanged);
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
            this.listBox1.Location = new System.Drawing.Point(228, 324);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // MedicalStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 838);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.medHSymtom);
            this.Controls.Add(this.medHDate);
            this.Name = "MedicalStaff";
            this.Text = "MedicalStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox medHDate;
        private System.Windows.Forms.ListBox medHSymtom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}