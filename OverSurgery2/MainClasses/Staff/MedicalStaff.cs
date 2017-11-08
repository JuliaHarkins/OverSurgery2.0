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
        private int? m_prescriptionLevel;
        private string m_phoneNumber;
#endregion
#region Constructors
        public MedicalStaff()
        {
            m_prescriptionLevel = null;
            m_phoneNumber = null;
        }
#endregion
#region Properties
        public enum Gender
        { Male, Female }
        public int? PrescriptionLevel
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
            StringBuilder bld;
            Random rand;
#endregion
#region Initialisation
            prescriptionID = null;
            dateFrom = null;
            dateUntil = null;
            repeat = false;
            prescription = new string[10];
            bld = new StringBuilder();
            bld.Remove(0, bld.Length);
            rand = new Random();
#endregion
#region Execution
            //prescriptionID = "SELECT PrescriptionID FROM Prescription".Count + 1;
            bld.Append("INSERT INTO Prescription VALUES (");
            bld.Append(prescriptionID);
            bld.Append(", ");
            bld.Append(prescription);
            bld.Append(");");
#endregion
#region return
            return bld.ToString();
#endregion
        }
    }
}
