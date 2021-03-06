﻿/* Created by: L
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
        private string m_notes, m_forenameDisplay, m_surnameDisplay, m_timeDisplay;
        private int m_medicalStaffID, m_patientID, m_appointmentID;
        private DateTime m_appDate, m_appTime;
        private bool m_appAttend;
       
        MetaLayer ml;

        public string Notes { get { return m_notes; } set { m_notes = value; } } //Appointment.Notes;  
        public int MedicalStaffID { get { return m_medicalStaffID; } set { m_medicalStaffID = value; } }
        public int PatientID { get { return m_patientID; } set { m_patientID = value; } }        
        public DateTime AppDate { get { return m_appDate; } set { m_appDate = value; } }
        public DateTime AppTime { get { return m_appTime; } set { m_appTime = value; } }   // Stores the date and time of the appointment
        public int AppointmentID { get { return m_appointmentID; } set { m_appointmentID = value; } }
        public bool AppAttend { get { return m_appAttend; } set { m_appAttend = value; } }
        public string ForeNameDisplay { get { return m_forenameDisplay; } }
        public string SurNameDisplay { get { return m_surnameDisplay; } }
        public string TimeDisplay { get { return m_timeDisplay; } set { m_timeDisplay = value; } }

        /// <summary>
        /// Gets the details of the appointment from the AppointmentControler and patient details from the database
        /// </summary>
        /// <param name="p_appValues"></param>
        public Appointment()
        {
            ml = MetaLayer.Instance();
            
            
        }
        public void SetNameDisplay()
        {
            TimeDisplay = AppTime.ToShortTimeString();
            m_forenameDisplay = PatientController.Instance().patients.Find(p => (p.ID == m_patientID)).Forename;
            m_surnameDisplay = PatientController.Instance().patients.Find(p => (p.ID == m_patientID)).Surname;
        }


    }

}
