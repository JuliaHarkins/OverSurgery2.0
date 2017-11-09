using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery.Main_Classes;

namespace OverSurgery
{
    /// <summary>
    /// 
    /// </summary>
    public class Doctor : MedicalStaff
    {
        #region Member Variables 
        string m_firstName;
        string m_lastName;
        string m_email;
        int m_staffID;
        string m_username;
        string m_password;
        int m_prescriptionLevel;
        int m_gender;
        string m_phoneNumber;
        bool m_onCall;
        List<Prescription> m_extension;


        #endregion

        /// <summary>
        /// used to create a doctor
        /// 07/11/2017 - j
        /// </summary>
        #region Constructor
        public Doctor(int p_staffID, string p_firstName, string p_lastName, string p_email, string p_username, string p_password, int p_prescriptionLevel, int p_gender, string p_phoneNumber)
        {

            m_firstName = p_firstName;
            m_lastName = p_lastName;
            m_email = p_email;
            m_staffID = p_staffID;
            m_username = p_username;
            m_password = p_password;
            m_prescriptionLevel = p_prescriptionLevel;
            m_phoneNumber = p_phoneNumber;
            m_onCall = false;
            m_gender = p_gender;
            
        }
        #endregion
        #region Properties
        public bool OnCall
        {
            get
            {
                return m_onCall;
            }
        }
        public List<Prescription> Extension
        {
            get
            {
                return m_extension;
            }

        }
        #endregion
        #region Methoods
        /// <summary>
        /// takes the perscription, returns a bool, then removes it from the doctors extention requests
        /// 01/11/2017 - j
        /// </summary>
        /// <param name="p_prescription"></param>
        /// <returns></returns>
        private bool ExtendMedication(Prescription p_prescription)
        {
            RemoveExtention(p_prescription);
            return true;

        }
        /// <summary>
        /// Removes the perscription from the extend list without updating it.
        /// 07/11/2017 - j
        /// </summary>
        /// <param name="p_prescription"></param>
        private void RemoveExtention(Prescription p_prescription)
        {
            m_extension.Remove(p_prescription);
        }
        #endregion
    }
}
