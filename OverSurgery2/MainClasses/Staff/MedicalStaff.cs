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
        #endregion
        #region Constructors
        public MedicalStaff(Dictionary<string, object> p_PersonValues) :base(p_PersonValues)
        {
           
            m_medicalStaffID = Convert.ToUInt16(p_PersonValues["MedicalStaffID"]);
            m_prescriptionLevel = Convert.ToUInt16(p_PersonValues["PrescriptionLevel"]);
            
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
