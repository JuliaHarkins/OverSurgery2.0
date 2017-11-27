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

namespace OverSurgery2
{
    public partial class ReceptionistForm : Form
    {
        BindingSource PatientBinding = new BindingSource();
        BindingSource AppointmentBinding = new BindingSource();
        Staff currentUserLoggedIn = null;
        PatientController pc;
        AppointmentController ac;
        int m_loadretrycountp = 0;
        int m_loadretrycounta = 0;
        public ReceptionistForm(Staff currentUser)
        {
            currentUserLoggedIn = currentUser;
            InitializeComponent();
            pc = PatientController.Instance();
            ac = AppointmentController.Instance();
        }



        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            pc.UpdatePatientDoctorDisplay();
            this.Text = "Logged in: " + currentUserLoggedIn.Forename + " " + currentUserLoggedIn.Surname + " as Receptionist";
            LoadAllPatientInfo();
            LoadAllAppointments();
            
        }
        #region DataGridView Loading
        private void LoadAllPatientInfo()
        {
            DataGridPatients.DataSource = PatientBinding.DataSource = pc.patients;
            SetPatientsDisplay();
            DataGridPatients.Update();
            DataGridPatients.Refresh();
            if (pc.patients.Count == 0)
            {
                DialogResult result = MessageBox.Show("No Patients Loaded from Database", "No Patients!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

                if (m_loadretrycountp == 5)
                {
                    MessageBox.Show("Maximum Retries Reached!");
                }
                else if (result == DialogResult.Abort)
                {
                    DialogResult abortresult = MessageBox.Show("Are you sure you would like to abort?", "Abort?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (abortresult == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else if (result == DialogResult.Retry)
                {
                    m_loadretrycountp++;
                    LoadAllPatientInfo();
                }
            }
            lbl_PatientCount.Text = "Number of Patients: " + pc.patients.Count;
        }

        private void LoadAllAppointments()
        {
            DataGridAppointments.DataSource = AppointmentBinding.DataSource = ac.Appointments;
            SetAppointmentDisplay();
            DataGridAppointments.Update();
            DataGridAppointments.Refresh();
            if (ac.Appointments.Count == 0)
            {
                DialogResult result = MessageBox.Show("No Appointments Loaded from Database", "No Appointments!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

                if (m_loadretrycounta == 5)
                {
                    MessageBox.Show("Maximum Retries Reached!");
                }
                else if (result == DialogResult.Abort)
                {
                    DialogResult abortresult = MessageBox.Show("Are you sure you would like to abort?", "Abort?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (abortresult == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else if (result == DialogResult.Retry)
                {
                    m_loadretrycounta++;
                    LoadAllAppointments();
                }
            }
        }
#endregion
        #region DataGridView Vanity
        private void SetAppointmentDisplay()
        {
            #region SetColumnDisplaysAppointments
            DataGridPatients.RowHeadersVisible = false;
            DataGridAppointments.Columns["AppointmentID"].Visible = false;
            DataGridAppointments.Columns["AppointmentID"].DisplayIndex = 0;
            DataGridAppointments.Columns["AppTime"].Visible = false;
            DataGridAppointments.Columns["AppTime"].DisplayIndex = 0;
            DataGridAppointments.Columns["MedicalStaffID"].Visible = false;
            DataGridAppointments.Columns["MedicalStaffID"].DisplayIndex = 0;
            DataGridAppointments.Columns["PatientID"].Visible = false;
            DataGridAppointments.Columns["PatientID"].DisplayIndex = 0;
            DataGridAppointments.Columns["AppDate"].HeaderText = "Date";
            DataGridAppointments.Columns["AppDate"].DisplayIndex = 1;
            DataGridAppointments.Columns["TimeDisplay"].HeaderText = "Time";
            DataGridAppointments.Columns["TimeDisplay"].DisplayIndex = 2;
            DataGridAppointments.Columns["Notes"].DisplayIndex = DataGridAppointments.Columns.Count - 1;
            DataGridAppointments.Columns["AppAttend"].HeaderText = "Attended?";
            #endregion
        }
        private void SetPatientsDisplay()
        {
            #region SetColumnDisplaysPatients
            DataGridPatients.Columns["GenderDisplay"].HeaderText = "Gender";
            DataGridPatients.Columns["DoctorDisplay"].HeaderText = "Registered Doctor";
            DataGridPatients.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            DataGridPatients.Columns["Forename"].DisplayIndex = 1;
            DataGridPatients.Columns["Surname"].DisplayIndex = 2;
            DataGridPatients.RowHeadersVisible = false;
            DataGridPatients.Columns["ID"].Visible = false;
            DataGridPatients.Columns["Gender"].Visible = false;
            DataGridPatients.Columns["AddressID"].Visible = false;
            DataGridPatients.Columns["PhoneNumber"].Visible = false;
            DataGridPatients.Columns["RegisteredDoctorID"].Visible = false;
            DataGridPatients.Columns["RegisteredDoctorID"].Visible = false;
            #endregion
        }
#endregion

        private Patient GetPatientByID()
        {
            return pc.patients.FirstOrDefault(p => p.ID == Convert.ToInt16(DataGridPatients.CurrentRow.Cells[0].Value));
        }


        #region Click Events
        private void btn_Logout_click(object sender, EventArgs e)
        {
            this.Close();
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

            PatientBinding.DataSource = pc.patients.FirstOrDefault(
                p => p.Forename.ToLower() == txt_SearchForename.Text.ToLower() &&
                p.Surname.ToLower() == txt_SearchSurname.Text.ToLower());
            DataGridPatients.DataSource = PatientBinding;
            SetPatientsDisplay();
            DataGridPatients.Update();
            DataGridPatients.Refresh();
        }

        private void btn_ViewAllPatients_Click(object sender, EventArgs e)
        {
            LoadAllPatientInfo();
        }

        private void btn_SearchApp_Click(object sender, EventArgs e)
        {
            AppointmentBinding.DataSource = ac.Appointments.Find(
                a => a.PatientID == pc.patients.FirstOrDefault(
                    p => p.Forename.ToLower() == txt_SearchAppForename.Text.ToLower()
                    && p.Surname.ToLower() == txt_SearchAppSurname.Text.ToLower()).ID);
            DataGridAppointments.DataSource = AppointmentBinding;
            SetAppointmentDisplay();
            DataGridAppointments.Update();
            DataGridAppointments.Refresh();
        }
        private void DataGridPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormController.Instance().OpenPatientViewForm(GetPatientByID());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
#endregion
        #region Appointment TextBox Vanity
        private void txt_SearchAppForename_Enter(object sender, EventArgs e)
        {
            txt_SearchAppForename.Text = "";
        }

        private void txt_SearchAppForename_Leave(object sender, EventArgs e)
        {
            if (txt_SearchAppForename.Text == "")
            {
                txt_SearchAppForename.Text = "Forename";
            }
        }

        private void txt_SearchAppSurname_Enter(object sender, EventArgs e)
        {
            txt_SearchAppSurname.Text = "";
        }

        private void txt_SearchAppSurname_Leave(object sender, EventArgs e)
        {
            if (txt_SearchAppSurname.Text == "")
            {
                txt_SearchAppSurname.Text = "Surname";

            }
        }
        #endregion
        #region Patients TextBox Vanity
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
#endregion
    }
    }
