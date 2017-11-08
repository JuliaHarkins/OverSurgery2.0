using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OverSurgery
{
    public partial class ReceptionistForm : Form
    {
        BindingSource PatientBinding;
        string currentUserLoggedIn;
        MetaLayer ml = MetaLayer.Instance();
        FormController fc = FormController.Instance();
        public ReceptionistForm(string currentUser)
        {
            InitializeComponent();
            currentUserLoggedIn = currentUser;
            this.ShowDialog();

            
        }

        private void btn_Logout_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            PatientBinding = new BindingSource();
            PatientBinding.DataSource = ml.getPatients();
            DataGridPatients.DataSource = PatientBinding;
            DataGridPatients.Columns["FirstName"].DisplayIndex = 1;
            DataGridPatients.Columns["LastName"].DisplayIndex = 2;
            DataGridPatients.Columns["Address"].Visible = false;
            DataGridPatients.Columns["PhoneNumber"].Visible = false;
            DataGridPatients.Columns["EmailAddress"].Visible = false;
            this.Text = "Logged in: " + currentUserLoggedIn + " as Receptionist";
        }


        private void DataGridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                try
                {
                    int id = Convert.ToInt32(DataGridPatients.CurrentRow.Cells[0].Value);
                    fc.OpenPatientViewForm(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
        }
    }
}
