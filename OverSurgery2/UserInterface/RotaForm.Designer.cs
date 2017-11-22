namespace OverSurgery2
{
    partial class RotaForm
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
            this.dG_Rota = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Staff_Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Rota)).BeginInit();
            this.SuspendLayout();
            // 
            // dG_Rota
            // 
            this.dG_Rota.AllowUserToAddRows = false;
            this.dG_Rota.AllowUserToDeleteRows = false;
            this.dG_Rota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Rota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staff_Forename,
            this.Staff_Surname,
            this.Day_Monday,
            this.Day_Tuesday,
            this.Day_Wednesday,
            this.Day_Thursday,
            this.Day_Friday});
            this.dG_Rota.Location = new System.Drawing.Point(13, 13);
            this.dG_Rota.Name = "dG_Rota";
            this.dG_Rota.ReadOnly = true;
            this.dG_Rota.RowTemplate.Height = 24;
            this.dG_Rota.Size = new System.Drawing.Size(1012, 464);
            this.dG_Rota.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 501);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Rota";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Staff_Forename
            // 
            this.Staff_Forename.HeaderText = "Forename";
            this.Staff_Forename.Name = "Staff_Forename";
            this.Staff_Forename.ReadOnly = true;
            // 
            // Staff_Surname
            // 
            this.Staff_Surname.HeaderText = "Surname";
            this.Staff_Surname.Name = "Staff_Surname";
            this.Staff_Surname.ReadOnly = true;
            // 
            // Day_Monday
            // 
            this.Day_Monday.HeaderText = "Monday";
            this.Day_Monday.Name = "Day_Monday";
            this.Day_Monday.ReadOnly = true;
            // 
            // Day_Tuesday
            // 
            this.Day_Tuesday.HeaderText = "Tuesday";
            this.Day_Tuesday.Name = "Day_Tuesday";
            this.Day_Tuesday.ReadOnly = true;
            // 
            // Day_Wednesday
            // 
            this.Day_Wednesday.HeaderText = "Wednesday";
            this.Day_Wednesday.Name = "Day_Wednesday";
            this.Day_Wednesday.ReadOnly = true;
            // 
            // Day_Thursday
            // 
            this.Day_Thursday.HeaderText = "Thursday";
            this.Day_Thursday.Name = "Day_Thursday";
            this.Day_Thursday.ReadOnly = true;
            // 
            // Day_Friday
            // 
            this.Day_Friday.HeaderText = "Friday";
            this.Day_Friday.Name = "Day_Friday";
            this.Day_Friday.ReadOnly = true;
            // 
            // RotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 536);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dG_Rota);
            this.Name = "RotaForm";
            this.Text = "RotaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dG_Rota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dG_Rota;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Friday;
    }
}