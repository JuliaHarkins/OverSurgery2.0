﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery2.Main_Classes;

namespace OverSurgery2
{
   /*
    
         
   */
    public class Doctor : MedicalStaff
    {
        #region Member Variables 
        string m_Forename;
        string m_Surname;
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
        
         public Doctor(Dictionary<string, object> p_medicalStaffValues) :base(p_medicalStaffValues)
             {
                
                //m_prescriptionLevel = Convert.ToInt16(p_medicalStaffValues["PrescriptionLevel"]);
                m_onCall = false;
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
