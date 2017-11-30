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
            this.cbx_Months = new System.Windows.Forms.ComboBox();
            this.btn_Extend = new System.Windows.Forms.Button();
            this.lbl_Months = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Months
            // 
            this.cbx_Months.FormattingEnabled = true;
            this.cbx_Months.Location = new System.Drawing.Point(85, 6);
            this.cbx_Months.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Months.Name = "cbx_Months";
            this.cbx_Months.Size = new System.Drawing.Size(80, 28);
            this.cbx_Months.TabIndex = 0;
            // 
            // btn_Extend
            // 
            this.btn_Extend.Location = new System.Drawing.Point(173, 2);
            this.btn_Extend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Extend.Name = "btn_Extend";
            this.btn_Extend.Size = new System.Drawing.Size(116, 35);
            this.btn_Extend.TabIndex = 1;
            this.btn_Extend.Text = "Extend";
            this.btn_Extend.UseVisualStyleBackColor = true;
            this.btn_Extend.Click += new System.EventHandler(this.btn_Extend_Click);
            // 
            // lbl_Months
            // 
            this.lbl_Months.AutoSize = true;
            this.lbl_Months.Location = new System.Drawing.Point(12, 9);
            this.lbl_Months.Name = "lbl_Months";
            this.lbl_Months.Size = new System.Drawing.Size(66, 20);
            this.lbl_Months.TabIndex = 2;
            this.lbl_Months.Text = "Months:";
            // 
            // PrescriptionExtendDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 48);
            this.Controls.Add(this.lbl_Months);
            this.Controls.Add(this.btn_Extend);
            this.Controls.Add(this.cbx_Months);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrescriptionExtendDialog";
            this.Text = "Extend Prescription";
            this.Load += new System.EventHandler(this.PrescriptionExtendDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Months;
        private System.Windows.Forms.Button btn_Extend;
        private System.Windows.Forms.Label lbl_Months;
    }
}