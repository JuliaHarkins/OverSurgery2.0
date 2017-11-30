using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This form is from all medical staff allowing them to prefrom 
 * their dayly functuions while creating and updating records.
 * 
 * Last Updated : 15/11/17
 * By: J
 */

namespace OverSurgery2
{
    public partial class MedicalStaffForm : Form
    {
#region Members
        MetaLayer ml = MetaLayer.Instance();                // the interface between the databae and the Application
        BindingSource m_appointmentBinding;                 // binds the information from the database
        List<Appointment> m_appointments;                   // the list of the current users appointments for today
        List<MedicalHistory> m_medicalHistory;
        List<Prescription> m_prescriptions;
        MedicalStaff m_currentUser; 
        int m_appointmentListCounter;                       // the current position in the appointment list.
        #endregion
#region Constructor
        /// <summary>
        /// Checks if the user is a doctor or a general medical staff member
        /// so that the correct buttons are shown. 
        /// </summary>
        /// <param name="p_currentUser">the user who has logged on</param>
        public MedicalStaffForm(Staff p_currentUser)
        {
            m_currentUser = p_currentUser as MedicalStaff;
            InitializeComponent();
        }
#endregion
#region Load
        /// <summary>
        /// what happens on the load of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MedicalStaff_Load(object sender, EventArgs e)
        {
            //checks there is information to load, and shows the relivent appointment information.
#region LoadingAppointmentList
            m_appointmentBinding = new BindingSource();

                m_appointments = ml.GetStaffAppointments(Convert.ToInt16(m_currentUser.MedicalStaffID));
            
            foreach (Appointment a in m_appointments)
            {
                a.SetNameDisplay();
            }
            dgv_AppointmentList.DataSource = m_appointmentBinding.DataSource = m_appointments;
            dgv_AppointmentList.Columns["ForeNameDisplay"].HeaderText = "Forename";
            dgv_AppointmentList.Columns["SurNameDisplay"].HeaderText = "Surname";
            dgv_AppointmentList.Columns["AppointmentID"].Visible = false;
            dgv_AppointmentList.RowHeadersVisible = false;
            dgv_AppointmentList.Columns["MedicalStaffID"].Visible = false;
            dgv_AppointmentList.Columns["PatientID"].Visible = false;
            dgv_AppointmentList.Columns["AppDate"].Visible = false;
            dgv_AppointmentList.Columns["AppAttend"].Visible = false;
            dgv_AppointmentList.Columns["AppTime"].Visible = false;
            dgv_AppointmentList.Columns["TimeDisplay"].DisplayIndex = 1;
            dgv_AppointmentList.Columns["TimeDisplay"].HeaderText = "Time";
            dgv_AppointmentList.Columns["Notes"].DisplayIndex = dgv_AppointmentList.ColumnCount -1;

            //setting the first selected row in appointment List.
            if (dgv_AppointmentList.RowCount > 0)
            {
                m_appointmentListCounter = 0;
                dgv_AppointmentList.CurrentCell = dgv_AppointmentList[0, m_appointmentListCounter];
                dgv_AppointmentList.CurrentRow.Selected = true;
            }

            #endregion
            SelectMedicalHistory();
            //shows the current user
#region ShowCurrentUser

                lb_currentUser.Text = "Current User : " + m_currentUser.Forename + " " + m_currentUser.Surname;

            #endregion
#region SetsExtentionAmount
            //checks if the user is a doctor and shows the amount of extentions,
            //or it hides the button from non-doctors
            if (m_currentUser.Type == 3)
            {
                int extention = ml.DoctorExtentionCount(Convert.ToInt32(m_currentUser.MedicalStaffID));

                if (extention != 0)
                {
                    btn_extRequest.Text = "Extention Requests : " + extention;
                    
                }
                else
                {
                    btn_extRequest.Text = "Extention Requests : 0";
                }
                btn_extRequest.Visible = true;
            }
            else
            {
                btn_extRequest.Hide();
            }
#endregion
        }
#endregion
#region Lable
        private void lb_notes_Click(object sender, EventArgs e)
        {

        }

        private void lb_MedHistory_Click(object sender, EventArgs e)
        {

        }

        private void lb_appList_Click(object sender, EventArgs e)
        {

        }

        private void lb_currentUser_Click(object sender, EventArgs e)
        {

        }
 #endregion
#region Button
        private void btn_addPrescription_Click(object sender, EventArgs e)
        {
            if (m_currentUser != null)
            {
                string patientName = m_appointments[m_appointmentListCounter].ForeNameDisplay + " " + m_appointments[m_appointmentListCounter].SurNameDisplay;
                new AddPrescription(m_currentUser, m_appointments[m_appointmentListCounter].PatientID, patientName).ShowDialog();
            }
            SelectMedicalHistory();
        }

        private void btn_extRequest_Click(object sender, EventArgs e)
        {
            new MedicalExtention(Convert.ToInt32(m_currentUser.MedicalStaffID)).ShowDialog();
                
        }
        /// <summary>
        /// saves the new patient notes to the medical hsitory of the patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveNotes_Click(object sender, EventArgs e)
        {
            MedicalHistory mh;
            if (btn_saveNotes.Text != null)
            {
                mh = new MedicalHistory
                    {
                         ID = null,
                         Notes =txt_CurrentNotes.Text,
                         Date = DateTime.Now,
                         PatientID = m_appointments[m_appointmentListCounter].PatientID
                    };

                ml.AddMedicalHistoryToTheDatabase(mh);
                txt_CurrentNotes.Clear();
                SelectMedicalHistory();
                /*
                 * Neater solution
                 * ml.AddMedicalHistoryToTheDatabase(
                 * new Notes { PatientID = m_currentPatient.ID, MedHistory = CurrentNotes.Text, DateOf = DateTime.Now, MedicalHistoryID = null});
                 */
            }
        }
        /// <summary>
        /// highlights next patient appointment upon click of button and de selects the currently selected.
        /// </summary>
        /// <param name="sender">MedicalStaffForm</param>
        /// <param name="e"></param>
        private void btn_nextPatient_Click(object sender, EventArgs e)
        {
            if (dgv_AppointmentList.CurrentCell.RowIndex <= dgv_AppointmentList.RowCount
                && dgv_AppointmentList.CurrentCell.RowIndex >= 0)
            {
                dgv_AppointmentList.CurrentCell = dgv_AppointmentList[0, m_appointmentListCounter];
                dgv_AppointmentList.CurrentRow.Selected = false;

                if (m_appointmentListCounter < dgv_AppointmentList.RowCount - 1)
                {
                    m_appointmentListCounter++;
                }
                dgv_AppointmentList.CurrentCell = dgv_AppointmentList[0, m_appointmentListCounter];

                dgv_AppointmentList.CurrentRow.Selected = true;
                SelectMedicalHistory();
            }

        }
        

        /// <summary>
        /// Highlights the Previous Patient, and updates the list position upon click of button.
        /// </summary>
        /// <param name="sender">MedicalStaffForm</param>
        /// <param name="e"></param>
        private void btn_previousPatient_Click(object sender, EventArgs e)
        {

            if (dgv_AppointmentList.CurrentCell.RowIndex <= dgv_AppointmentList.RowCount && dgv_AppointmentList.CurrentCell.RowIndex > 0)
            {

                m_appointmentListCounter--;

                dgv_AppointmentList.CurrentRow.Selected = false;

                dgv_AppointmentList.CurrentCell = dgv_AppointmentList[0, m_appointmentListCounter];

                dgv_AppointmentList.CurrentRow.Selected = true;
                SelectMedicalHistory();
            }

        }
        /// <summary>
        /// Exits 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
#region DataGridView
        private void dgv_AppointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
#region TextBox
        private void txt_CurrentNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion
#region Method
        private void SelectMedicalHistory()
        {
            lst_MedicalHistory.Clear();
            lst_MedicalHistory.Columns.Add("Date", 75);
            lst_MedicalHistory.Columns.Add("Notes", 425);
            lst_Prescriptions.Clear();
            lst_Prescriptions.Columns.Add("Date", 75);
            lst_Prescriptions.Columns.Add("Medication", 175);
            lst_Prescriptions.Columns.Add("Amount", 75);
            lst_Prescriptions.Columns.Add("By", 148);

            m_medicalHistory = ml.GetPatientsMedicalHiatory(m_appointments[m_appointmentListCounter].PatientID);
            m_prescriptions = ml.GetPatientsPrescriptions(m_appointments[m_appointmentListCounter].PatientID);
            foreach (MedicalHistory mh in m_medicalHistory)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = mh.Date.ToShortDateString();
                lvi.SubItems.Add(mh.Notes);
                lst_MedicalHistory.Items.Add(lvi);
            }
            foreach (Prescription p in m_prescriptions)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Date.ToShortDateString();
                lvi.SubItems.Add(ml.GetMedicationName(p.MedicationID));
                lvi.SubItems.Add(p.Amount.ToString());
                //using the medStaff id, I get the staff id and find out the full title and name of the medicalStaff member
                lvi.SubItems.Add(ml.GetStaffNameAndTitle(ml.GetStafIDFromMedStaffID(p.MedicalStaffID)));
                lst_Prescriptions.Items.Add(lvi);

            }
            
        }
#endregion
#region Lists

        private void lst_MedicalHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Prescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
