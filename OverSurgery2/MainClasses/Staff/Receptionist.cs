using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery2.Main_Classes;

namespace OverSurgery2
{
    /*
    * The object used to update patient details and appointments,
    * this also includes the creation of appointments, and sends 
    * extention requests for the doctor to sign off on.
    * 
    * Created By: J
    * Last Updated : 14/11/17
    */
    public class Receptionist : Staff
    {
#region Member Variables
        List<Prescription> m_extension;
        FormController fc = FormController.Instance();
#endregion
#region Properties
        List<Prescription> Extention
        {
            set
            {
                m_extension = value;
            }
        }
        #endregion

        public Receptionist(Dictionary<string, object> p_PersonValues) :base(p_PersonValues)
        {
            
        }

        /// <summary>
        /// gives the docter a new prescription to extend.
        /// 01/11/2017 -j
        /// </summary>
        /// <param name="p_prescription"></param>
        public void AddPrescription(Prescription p_prescription)
        {
            m_extension.Add(p_prescription);
            //MetaLayer.Instance().AddPrescription(m_extension);

        }
        /// <summary>
        /// The operation used to Create Appointments.
        /// </summary>
        public void SetAppointment()
        {

        }
        /// <summary>
        /// Adds a new patient to the clinic
        /// </summary>
        public void AddPatient()
        {

        }
        /// <summary>
        /// edits a patient
        /// </summary>
        public void EditPatient()
        {
        }
        /// <summary>
        /// removes an appointment
        /// </summary>
        public void CancelAppointment()
        {

        }
        /// <summary>
        /// sets patients ti 'inactive'
        /// </summary>
        public void RemovePatient()
        {

        }
    }
}
