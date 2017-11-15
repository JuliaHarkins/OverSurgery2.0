using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * this object is used to hold all information needed for a perscription,
 * and allow for their extention
 * 
 * Last Updated : 15/11/17
 * By: J
 */

namespace OverSurgery2.Main_Classes
{
    /// <summary>
    /// this object is used to hold all information needed for a perscription,
    ///and allow for their extention.
    /// </summary>
    public class Prescription
    {
#region member Varibles 
        MetaLayer ml;
        int m_medicationID; 
        int m_patientID;
        DateTime m_DateOfNextIssue;
        bool m_allowExtention;
        DateTime m_DateIssued;
        DateTime m_expirationDate;
        int m_Amount;
        int m_MedicalStaffID;
#endregion

        /// <summary>
        /// Creates the prescriptions 
        /// </summary>
        /// <param name="p_PrescriptionValues">The MedicaltionID, PatientID, ExterationDate, 
        /// Ammount, MedicalStaffID, DateIssued, and DateOfNextIssue are used to create the
        /// perscriptions </param>
        #region Constructor
        public Prescription(Dictionary<string, object> p_PrescriptionValues)
        {
            ml = MetaLayer.Instance();
            m_medicationID = Convert.ToInt16(p_PrescriptionValues["PrescriptionID"]);
            m_patientID = Convert.ToInt16(p_PrescriptionValues["PatientID"]);
            m_expirationDate = Convert.ToDateTime(p_PrescriptionValues["ExpirationDate"]);
            m_Amount = Convert.ToInt16(p_PrescriptionValues["Amount"]);
            m_MedicalStaffID = Convert.ToInt16(p_PrescriptionValues["MedicalStaffID"]);
            m_DateIssued = Convert.ToDateTime(p_PrescriptionValues["DateIssued"]);
            m_DateOfNextIssue = Convert.ToDateTime(p_PrescriptionValues["DateOfNextIssue"]); 
        }
        #endregion
        #region Methods
        /// <summary>
        /// extents the perscription by one month
        /// </summary>
        public void Extend()
        {
            #region Execution
                if (m_DateOfNextIssue < DateTime.Now && CheckIfExtenable() == true)
                {
                    m_expirationDate.AddMonths(1);
                }
            else {

            }
#endregion
        }
        /// <summary>
        /// extends by a given amount of months.
        /// </summary>
        /// <param name="p_months">the amout of months the perscription is to be extended by.</param>
        public void Extend(int p_months)
        {
#region Execution

            if (m_DateOfNextIssue > DateTime.Now && CheckIfExtenable() == true)
            {
                m_expirationDate.AddMonths(p_months);
            }
#endregion
        }
        private bool CheckIfExtenable()
        {
#region Exicution
            if (m_allowExtention == true)
            {
                return true;
            }
            else{
                return false;
            }
#endregion
        }
#endregion

    }
}
