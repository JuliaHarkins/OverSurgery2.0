﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OverSurgery2
{
    public partial class ReceptionistForm : Form
    {
        BindingSource PatientBinding;
        Staff currentUserLoggedIn = null;
        MetaLayer ml = MetaLayer.Instance();
        FormController fc = FormController.Instance();
        AppointmentController ac;
        public ReceptionistForm(Staff currentUser)
        {
            currentUserLoggedIn = currentUser;
            InitializeComponent();
            this.ShowDialog();
        }

        private void btn_Logout_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            PatientBinding = new BindingSource();
            DataGridPatients.DataSource = PatientBinding.DataSource = ml.getPatients();
            DataGridPatients.Columns["Forename"].DisplayIndex = 1;
            DataGridPatients.Columns["Surname"].DisplayIndex = 2;
            DataGridPatients.Columns["AddressID"].Visible = false;
            DataGridPatients.Columns["PhoneNumber"].Visible = false;
            this.Text = "Logged in: " + currentUserLoggedIn.Forename + " " + currentUserLoggedIn.Surname + " as Receptionist";
        }


        private void DataGridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                try
                {
                    fc.OpenPatientViewForm(ml.GetPatientByID(Convert.ToInt16(DataGridPatients.CurrentRow.Cells[0].Value)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
        }

        private void txt_SearchSurname_Enter(object sender, EventArgs e)
        {
            txt_SearchSurname.Text = "";
        }

        private void txt_SearchSurname_Leave(object sender, EventArgs e)
        {
            txt_SearchSurname.Text = "Surname";
        }

        private void txt_SearchForename_Enter(object sender, EventArgs e)
        {
            txt_SearchForename.Text = "";
        }

        private void txt_SearchForename_Leave(object sender, EventArgs e)
        {
            txt_SearchForename.Text = "Forename";
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            fc.OpenNewPatientForm();
        }
    }
}
