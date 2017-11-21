using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Created By: J
    /// Implemented By: E
    /// Date Created : 31/10/17
    /// </summary>
    public class MedicalStaff : Staff
    {
        #region Member Variables

        private uint? m_medicalStaffID;
        private uint? m_prescriptionLevel;
        private string m_practiceNumber;
        private uint? m_gender;
        private string m_genderDisplay;
        private string m_phoneNumber;
        #endregion
        #region Constructors
        public MedicalStaff()
        {
            if (m_gender == 1)
            {
                m_genderDisplay = "Male";
            }
            else
            {
                m_genderDisplay = "Female";
            }
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
        public uint? MedicalStaffID
        {
            get
            {
                return m_medicalStaffID;
            }
            set
            {
                m_medicalStaffID = value;
            }
        }
        public string GenderDisplay { get { return m_genderDisplay; } }
        public string PracticeNumber { get { return m_practiceNumber; } set { m_practiceNumber = value; } }
        public uint? Gender { get { return m_gender; } set { m_gender = value; } }
        public string PhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
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
#endregion
#region return
            return null;
#endregion
        }
    }
}
