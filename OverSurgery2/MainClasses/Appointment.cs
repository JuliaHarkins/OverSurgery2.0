/* Created by: L
 * First Created: 20/10/17
 * Last Edit: 14/11/17 16:22
 * Last Edit by: R
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Handles appointment data
    /// </summary>
    public class Appointment
    {
#region Member Variables
        private string m_notes;
        private int m_medicalStaffID;
        private int m_patientID;
        private DateTime m_appDate;
        private DateTime m_appTime;
        private int m_appointmentID;
        private bool m_appAttend;
        private string m_forenameDisplay;
        private string m_surnameDisplay;
        private string m_timeDisplay;
        MetaLayer ml;
#endregion
#region Properties
        public string Notes { get { return m_notes; } set { m_notes = value; } } //Appointment.Notes;  
        public int MedicalStaffID { get { return m_medicalStaffID; } set { m_medicalStaffID = value; } }
        public int PatientID { get { return m_patientID; } set { m_patientID = value; } }        
        public DateTime AppDate { get { return m_appDate; } set { m_appDate = value; } }
        public DateTime AppTime { get { return m_appTime; } set { m_appTime = value; } }                                                                               // Stores the date and time of the appointment
        public int AppointmentID { get { return m_appointmentID; } set { m_appointmentID = value; } }
        public bool AppAttend { get { return m_appAttend; } set { m_appAttend = value; } }
        public string ForeNameDisplay { get { return m_forenameDisplay; } }
        public string SurNameDisplay { get { return m_surnameDisplay; } }
        public string TimeDisplay { get { return m_timeDisplay; } set { m_timeDisplay = value; } }
        #endregion


        /// <summary>
        /// Gets the details of the appointment from the AppointmentControler and patient details from the database
        /// </summary>
        /// <param name="p_appValues"></param>
        public Appointment(Dictionary <string,object> p_appValues)
        {
            ml = MetaLayer.Instance();
            AppointmentID = Convert.ToInt16(p_appValues["AppID"]);
            MedicalStaffID = Convert.ToInt16(p_appValues["MedStaffID"]);
            PatientID = Convert.ToInt16(p_appValues["PatientID"]);
            AppDate = DateTime.Parse(p_appValues["Date"].ToString());
            AppTime = DateTime.Parse(p_appValues["Time"].ToString());
            TimeDisplay = AppTime.ToShortTimeString();
            Notes = Convert.ToString(p_appValues["Notes"]);
            AppAttend = Convert.ToBoolean(p_appValues["Attend"]);
            
        }
        public void SetNameDisplay()
        {
            m_forenameDisplay = ml.GetPatientByID(m_patientID).Forename;
            m_surnameDisplay = ml.GetPatientByID(m_patientID).Surname;
        }


    }

}
