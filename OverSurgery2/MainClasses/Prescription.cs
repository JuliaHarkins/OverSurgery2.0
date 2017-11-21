using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * this object is used to hold all information needed for a Prescription,
 * and allow for their extention
 * 
 * Last Updated : 15/11/17
 * By: J
 */

namespace OverSurgery2
{
    /// <summary>
    /// this object is used to hold all information needed for a Prescription,
    ///and allow for their extention.
    /// </summary>
    public class Prescription
    {
#region Members 
        MetaLayer ml;
        int m_prescriptionID;
        int m_medicationID; 
        int m_patientID;
        DateTime m_dateOfNextIssue;
        bool m_allowExtention;
        DateTime m_DateIssued;
        DateTime m_dateOfNetIssue;
        int m_amount;
        int m_medicalStaffID;
        #endregion
        #region Properties
        public int ID
        {
            get
            {
                return m_prescriptionID;
            }
            set
            {
                m_prescriptionID = value;
            }
        }
        public int PatientID
        {
            get
            {
                return m_patientID;
            }
            set
            {
                m_patientID = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return m_DateIssued;
            }
            set
            {
                m_DateIssued = value;
            }
        }
        public int MedicationID
        {
            get
            {
                return m_medicationID;
            }
            set
            {
                m_medicationID = value;
            }
        }
        public int Amount
        {
            get
            {
                return m_amount;
            }
            set
            {
                m_amount = value;
            }
        }
        public int MedicalStaffID
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
        public DateTime DateOfNextIssue
        {
            get
            {
                return m_dateOfNextIssue;
            }
            set
            {
                m_dateOfNextIssue = value;
            }
        }
        public bool Extendable
        {
            get
            {
                return m_allowExtention;
            }
            set
            {
                m_allowExtention = value;
            }
        }

        #endregion

        /// <summary>
        /// Creates the prescriptions
        /// </summary>
        /// <param name="p_PrescriptionValues">The MedicaltionID, PatientID, ExterationDate, 
        /// Ammount, MedicalStaffID, DateIssued, and DateOfNextIssue are used to create the
        /// Prescriptions </param>
        #region Constructor
        public Prescription()
        {
        }
        #endregion
        #region Methods
        /// <summary>
        /// extents the Prescription by one month
        /// </summary>
        public void Extend()
        {
            #region Execution
                if (m_dateOfNextIssue < DateTime.Now && CheckIfExtenable() == true)
                {
                    m_dateOfNetIssue.AddMonths(1);
                }
            else {

            }
#endregion
        }
        /// <summary>
        /// extends by a given amount of months.
        /// </summary>
        /// <param name="p_months">the amout of months the Prescription is to be extended by.</param>
        public void Extend(int p_months)
        {
#region Execution

            if (m_dateOfNextIssue > DateTime.Now && CheckIfExtenable() == true)
            {
                m_dateOfNetIssue.AddMonths(p_months);
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
