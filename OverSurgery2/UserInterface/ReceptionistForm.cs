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
#region  Member Variables
        private BindingSource m_patientBinding = new BindingSource();
        private BindingSource m_appointmentBinding = new BindingSource();
        private Staff currentUserLoggedIn;
        private PatientController pc;
        private AppointmentController ac;
        private int m_loadretrycountp = 0;
        private int m_loadretrycounta = 0;
        #endregion
        /// <summary>
        /// Constructor for ReceptionistForm
        /// </summary>
        /// <param name="p_currentUser">Current user logged in passed from FormController</param>
        public ReceptionistForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;
            InitializeComponent();
            pc = PatientController.Instance();
            ac = AppointmentController.Instance();
        }
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            pc.UpdatePatientDoctorDisplay();
            this.Text = @"Logged in: " + currentUserLoggedIn.Forename + " " + currentUserLoggedIn.Surname + @" as Receptionist";
            LoadAllPatientInfo();
            LoadAllAppointments();
            
        }
#region DataGridView Loading
        private void LoadAllPatientInfo()
        {
            dgv_Patients.DataSource = m_patientBinding.DataSource = pc.patients;
            SetDgvPatientsDisplay();
            dgv_Patients.Update();
            dgv_Patients.Refresh();
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
            dgv_Appointments.DataSource = m_appointmentBinding.DataSource = ac.Appointments;
            SetDgvAppointmentDisplay();
            dgv_Appointments.Update();
            dgv_Appointments.Refresh();
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
        /// <summary>
        /// Set the display for the appointments DataGridView, make it neater, hide fields that are not needed.
        /// </summary>
        private void SetDgvAppointmentDisplay()
        {
            #region SetColumnDisplaysAppointments
            dgv_Appointments.RowHeadersVisible = false;
            dgv_Appointments.Columns["AppointmentID"].Visible = false;
            dgv_Appointments.Columns["AppointmentID"].DisplayIndex = 0;
            dgv_Appointments.Columns["AppTime"].Visible = false;
            dgv_Appointments.Columns["AppTime"].DisplayIndex = 0;
            dgv_Appointments.Columns["MedicalStaffID"].Visible = false;
            dgv_Appointments.Columns["MedicalStaffID"].DisplayIndex = 0;
            dgv_Appointments.Columns["PatientID"].Visible = false;
            dgv_Appointments.Columns["PatientID"].DisplayIndex = 0;
            dgv_Appointments.Columns["AppDate"].HeaderText = @"Date";
            dgv_Appointments.Columns["AppDate"].DisplayIndex = 1;
            dgv_Appointments.Columns["TimeDisplay"].HeaderText = @"Time";
            dgv_Appointments.Columns["TimeDisplay"].DisplayIndex = 2;
            dgv_Appointments.Columns["Notes"].DisplayIndex = dgv_Appointments.Columns.Count - 1;
            dgv_Appointments.Columns["AppAttend"].HeaderText = @"Attended?";
            #endregion
        }

        /// <summary>
        /// Set the display for the patients DataGridView, make it neater, hide fields that are not needed.
        /// </summary>
        private void SetDgvPatientsDisplay()
        {
            #region SetColumnDisplaysPatients
            dgv_Patients.Columns["GenderDisplay"].HeaderText = @"Gender";
            dgv_Patients.Columns["DoctorDisplay"].HeaderText = @"Registered Doctor";
            dgv_Patients.Columns["DateOfBirth"].HeaderText = @"Date Of Birth";
            dgv_Patients.Columns["Forename"].DisplayIndex = 1;
            dgv_Patients.Columns["Surname"].DisplayIndex = 2;
            dgv_Patients.RowHeadersVisible = false;
            dgv_Patients.Columns["ID"].Visible = false;
            dgv_Patients.Columns["Gender"].Visible = false;
            dgv_Patients.Columns["AddressID"].Visible = false;
            dgv_Patients.Columns["PhoneNumber"].Visible = false;
            dgv_Patients.Columns["RegisteredDoctorID"].Visible = false;
            dgv_Patients.Columns["RegisteredDoctorID"].Visible = false;
            #endregion
        }
        #endregion
        /// <summary>
        /// Return a patient from the list of Patients, using ID of clicked patient in dgv_Patients
        /// </summary>
        /// <returns></returns>
        private Patient GetPatientById()
        {
            return pc.patients.FirstOrDefault(p => p.ID == Convert.ToInt16(dgv_Patients.CurrentRow.Cells[0].Value));
        }
#region Click Events
        private void btn_Logout_click(object sender, EventArgs e)
        {
            // Close Form, in turn logging user out
            this.Close();
        }
        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            //Open NewPatient form for new Patient details input
            FormController.Instance().OpenNewPatientForm();
            //Update the DataGrids
            dgv_Patients.Update();
            dgv_Patients.Refresh();
        }
        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {

            m_patientBinding.DataSource = pc.patients.FirstOrDefault(
                p => p.Forename.ToLower() == txt_SearchForename.Text.ToLower() &&
                p.Surname.ToLower() == txt_SearchSurname.Text.ToLower());
            dgv_Patients.DataSource = m_patientBinding;
            SetDgvPatientsDisplay();
            dgv_Patients.Update();
            dgv_Patients.Refresh();
        }

        private void btn_ViewAllPatients_Click(object sender, EventArgs e)
        {
            LoadAllPatientInfo();
        }

        private void btn_SearchApp_Click(object sender, EventArgs e)
        {
            m_appointmentBinding.DataSource = ac.Appointments.Find(
                a => a.PatientID == pc.patients.FirstOrDefault(
                    p => p.Forename.ToLower() == txt_SearchAppForename.Text.ToLower()
                    && p.Surname.ToLower() == txt_SearchAppSurname.Text.ToLower()).ID);
            dgv_Appointments.DataSource = m_appointmentBinding;
            SetDgvAppointmentDisplay();
            dgv_Appointments.Update();
            dgv_Appointments.Refresh();
        }
        private void DataGridPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                FormController.Instance().OpenPatientViewForm(GetPatientById());
        }
        private void btn_NewApp_Click(object sender, EventArgs e)
        {
            FormController.Instance().OpenNewAppointmentForm();
        }
        #endregion
#region Appointment TextBox Vanity
        private void txt_SearchAppForename_Enter(object sender, EventArgs e)
        {
            //Set textbox text to empty when user clicks on textbox
            txt_SearchAppForename.Text = "";
        }
        private void txt_SearchAppForename_Leave(object sender, EventArgs e)
        {
            if (txt_SearchAppForename.Text == "")
            {
                txt_SearchAppForename.Text = @"Forename";
            }
        }
        private void txt_SearchAppSurname_Enter(object sender, EventArgs e)
        {
            //Set textbox text to empty when user clicks on textbox
            txt_SearchAppSurname.Text = "";
        }
        private void txt_SearchAppSurname_Leave(object sender, EventArgs e)
        {
            if (txt_SearchAppSurname.Text == "")
            {
                txt_SearchAppSurname.Text = @"Surname";

            }
        }
        #endregion
#region Patients TextBox Vanity
        private void txt_SearchSurname_Enter(object sender, EventArgs e)
        {
            //Set textbox text to empty when user clicks on textbox
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
            //Set textbox text to empty when user clicks on textbox
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
