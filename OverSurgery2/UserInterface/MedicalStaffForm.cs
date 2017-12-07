using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        StringBuilder sb = new StringBuilder();
        int m_appointmentListCounter;                       // the current position in the appointment list.
        #endregion

        /// <summary>
        /// Checks if the user is a doctor or a general medical staff member
        /// so that the correct buttons are shown.
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        /// <param name="p_currentUser">the user who has logged on</param>
        public MedicalStaffForm(Staff p_currentUser)
        {
            m_currentUser = p_currentUser as MedicalStaff;
            InitializeComponent();
        }
        private void MedicalStaff_Load(object sender, EventArgs e)
        {
            //checks there is information to load, and shows the relivent appointment information.
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

            SelectMedicalHistory();
            //shows the current user

            lb_currentUser.Text = "Current User : " + m_currentUser.Forename + " " + m_currentUser.Surname;

            // Sets Extention Amount
            CheckExtentionButton();
        }

#region Button
        private void btn_addPrescription_Click(object sender, EventArgs e)
        {
            if (m_currentUser != null)
            {
                if (m_appointments.Count != 0)
                {
                    string patientName = m_appointments[m_appointmentListCounter].ForeNameDisplay + " " + m_appointments[m_appointmentListCounter].SurNameDisplay;
                    new AddPrescription(m_currentUser, m_appointments[m_appointmentListCounter].PatientID, patientName).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unable to add add a prescription as there is no patient selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SelectMedicalHistory();
        }

        private void btn_extRequest_Click(object sender, EventArgs e)
        {
            new MedicalExtention(Convert.ToInt32(m_currentUser.MedicalStaffID)).ShowDialog();
            CheckExtentionButton();
        }
        /// <summary>
        /// saves the new patient notes to the medical hsitory of the patient.
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveNotes_Click(object sender, EventArgs e)
        {
            string notes ="";
            MedicalHistory mh;
            if (txt_CurrentNotes.Text != "")
            {
                sb.Clear();
                foreach (var ch in txt_CurrentNotes.Text)
                {
                    if (ch == '\'')
                    {
                        sb.Append("\'").Append(ch);
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                    notes = sb.ToString();
                }
                
                if (m_appointments.Count != 0)
                {
                    mh = new MedicalHistory
                    {
                        ID = null,

                        

                    Notes = notes,
                        Date = DateTime.Now,
                        PatientID = m_appointments[m_appointmentListCounter].PatientID
                    };

                    ml.AddMedicalHistoryToTheDatabase(mh);
                    txt_CurrentNotes.Clear();
                    SelectMedicalHistory();
                }
                else
                {
                    MessageBox.Show("Unable to add Medical Histoy as there is no patient selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// highlights next patient appointment upon click of button and de selects the currently selected.
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        /// <param name="sender">MedicalStaffForm</param>
        /// <param name="e"></param>
        private void btn_nextPatient_Click(object sender, EventArgs e)
        {if (m_appointments.Count != 0)
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

        }


        /// <summary>
        /// Highlights the Previous Patient, and updates the list position upon click of button.
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        /// <param name="sender">MedicalStaffForm</param>
        /// <param name="e"></param>
        private void btn_previousPatient_Click(object sender, EventArgs e)
        {
            if (m_appointments.Count != 0)
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
        }
        /// <summary>
        /// Exits 
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOff_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (m_appointments.Count != 0)
            {
                m_medicalHistory = ml.GetPatientsMedicalHiatory(m_appointments[m_appointmentListCounter].PatientID);
                m_prescriptions = ml.GetPatientsPrescriptions(m_appointments[m_appointmentListCounter].PatientID);
                if (m_medicalHistory != null)
                {
                    foreach (MedicalHistory mh in m_medicalHistory)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = mh.Date.ToShortDateString();
                        lvi.SubItems.Add(mh.Notes);
                        lst_MedicalHistory.Items.Add(lvi);
                    }
                }
                if (m_prescriptions != null)
                {
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
            }
            
        }
#endregion
        /// <summary>
        /// Checks if the user is a doctor and updates the extentioin buttom accordingly 
        /// By j
        /// Last Updated : 30/11/17
        /// </summary>
        public void CheckExtentionButton()
        {
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
        }
    }
    
}
