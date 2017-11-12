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
            PatientController.Instance().UpdatePatientDoctorDisplay();
            LoadAllPatientInfo();
            DataGridPatients.Columns["GenderDisplay"].HeaderText = "Gender";
            DataGridPatients.Columns["DoctorDisplay"].HeaderText = "Registered Doctor";
            DataGridPatients.Columns["Forename"].DisplayIndex = 1;
            DataGridPatients.Columns["Surname"].DisplayIndex = 2;
            DataGridPatients.RowHeadersVisible = false;
            DataGridPatients.Columns["ID"].Visible = false;
            DataGridPatients.Columns["Gender"].Visible = false;
            DataGridPatients.Columns["AddressID"].Visible = false;
            DataGridPatients.Columns["PhoneNumber"].Visible = false;
            DataGridPatients.Columns["RegisteredDoctorID"].Visible = false;
            this.Text = "Logged in: " + currentUserLoggedIn.Forename + " " + currentUserLoggedIn.Surname + " as Receptionist";
        }
        private void LoadAllPatientInfo()
        {
            PatientBinding = new BindingSource();
            DataGridPatients.DataSource = PatientBinding.DataSource = PatientController.Instance().patients;
            DataGridPatients.Update();
            DataGridPatients.Refresh();
        }


        private void DataGridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                try
                {
                FormController.Instance().OpenPatientViewForm(MetaLayer.Instance().GetPatientByID(Convert.ToInt16(DataGridPatients.CurrentRow.Cells[0].Value)));
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
            if (txt_SearchSurname.Text == "")
            {
                txt_SearchSurname.Text = "Surname";
            }
        }

        private void txt_SearchForename_Enter(object sender, EventArgs e)
        {
            txt_SearchForename.Text = "";
        }

        private void txt_SearchForename_Leave(object sender, EventArgs e)
        {
            if (txt_SearchForename.Text == "")
            {
                txt_SearchForename.Text = "Forename";
            }
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            FormController.Instance().OpenNewPatientForm();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            DataGridPatients.Refresh();
            DataGridAppointments.Refresh();
        }

        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {
            PatientBinding = new BindingSource();
            var s = MetaLayer.Instance().GetPatientByName(txt_SearchForename.Text, txt_SearchSurname.Text);
            s.SetDoctorDisplay();
            PatientBinding.DataSource = s;
            DataGridPatients.DataSource = PatientBinding;
            DataGridPatients.Update();
            DataGridPatients.Refresh();
        }

        private void btn_ViewAllPatients_Click(object sender, EventArgs e)
        {
            LoadAllPatientInfo();
        }
    }
}
