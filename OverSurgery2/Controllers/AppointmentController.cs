/* Created by: J
 * Date Created : 31/10/17
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
    /// Handles interaction with appointment
    /// </summary>
    public class AppointmentController
    {
        Appointment a;
        private List<Appointment> m_appointments;

        public List<Appointment> Appointments { get { return m_appointments; } }

        List<Appointment> AppointmentList = new List<Appointment>();                                                                // List of properties to be sent and recieved       
        MetaLayer ml;

        private AppointmentController()
        {
            ml = MetaLayer.Instance();
            m_appointments = ml.GetAppointments();
            foreach(Appointment a in m_appointments)
            {
                a.SetNameDisplay();
            }
        }

        private static AppointmentController m_instance;
        public static AppointmentController Instance()
        {
            if(null == m_instance)
            {
                m_instance = new AppointmentController();
            }
            return m_instance;
        }

        /// <summary>
        /// Update an existing appointment with new data
        /// </summary>
        public void UpdateAppointment(Appointment app)
        {
            ml.UpdateAppointment(app);
        }

        /// <summary>
        /// Add a brand new appointment to the database
        /// </summary>
        public void AddNewAppointment(Appointment app)
        {
            ml.AddAppointment(app);
        }

        /// <summary>
        /// Find data about an existing appointment
        /// </summary>
        public void GetExistingAppointment(int p_patientID)
        {
            //Get exisiting appointment using patientID
            ml.GetAppointmentById(p_patientID);
        }
    }
}
