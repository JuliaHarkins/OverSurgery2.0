using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    /// <summary>
    /// Created By: J
    /// Implemented By: E
    /// Date Created : 31/10/17
    /// </summary>
    public class MedicalStaff : Staff
    {
        #region Member Variables
        private string m_forename;
        private string m_surname;
        private uint? m_medicalStaffID;
        private uint? m_gender;
        private uint? m_prescriptionLevel;
        private string m_phoneNumber;
        #endregion
        #region Constructors
        public MedicalStaff(Dictionary<string, object> p_medicalStaffValues)
        {
            m_forename = Convert.ToString(p_medicalStaffValues["Forename"]);
            m_surname = Convert.ToString(p_medicalStaffValues["Surname"]);
            m_medicalStaffID = Convert.ToUInt32(p_medicalStaffValues["MediclaStaffID"]);
            m_gender = Convert.ToUInt32(p_medicalStaffValues["Gender"]);
            m_prescriptionLevel = Convert.ToUInt32(p_medicalStaffValues["PrescriptionLevel"]);
            m_phoneNumber = Convert.ToString(p_medicalStaffValues["PhoneNumber"]);
        }
        #endregion
        #region Properties
        public uint? PrescriptionLevel
        {
            get
            {
                return m_prescriptionLevel;
            }
            set
            {
                m_prescriptionLevel = value;
            }
        }
        public uint? Gender
        {
            get
            {
                return m_gender;
            }
            set
            {
                m_gender = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return m_phoneNumber;
            }
            set
            {
                m_phoneNumber = value;
            }
        }
        #endregion
        public string PrescribeMedication(int? paitientID, int? prescribeeID, int? medicationID)
        {
#region Declaration
            int? prescriptionID;
            string dosage, frequency, notes;
            string dateFrom, dateUntil;
            bool repeat;
            string[] prescription;
            Random rand;
#endregion
#region Initialisation
            prescriptionID = null;
            dateFrom = null;
            dateUntil = null;
            repeat = false;
            prescription = new string[10];
            rand = new Random();
#endregion
#region Execution
            //
#endregion
#region return
            return null;
#endregion
        }
    }
}
