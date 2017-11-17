namespace OverSurgery2
{
    partial class ManagerForm
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnUpdateRota = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(12, 400);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(91, 23);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Location = new System.Drawing.Point(12, 342);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveStaff.TabIndex = 1;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(12, 371);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateStaff.TabIndex = 2;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnUpdateRota
            // 
            this.btnUpdateRota.Location = new System.Drawing.Point(12, 313);
            this.btnUpdateRota.Name = "btnUpdateRota";
            this.btnUpdateRota.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateRota.TabIndex = 3;
            this.btnUpdateRota.Text = "Update Rota";
            this.btnUpdateRota.UseVisualStyleBackColor = true;
            this.btnUpdateRota.Click += new System.EventHandler(this.btnUpdateRota_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 435);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRota);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnUpdateRota;
        private System.Windows.Forms.Button btnExit;
    }
}