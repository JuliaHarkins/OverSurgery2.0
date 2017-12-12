using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this object is used to hold all information needed for a Prescription,
/// and allow for their extention.
/// Last Updated : 27/11/2017/11/17
/// By: J
/// </summary>
namespace OverSurgery2
{
    /// <summary>
    /// this object is used to hold all information needed for a Prescription,
    /// and allow for their extention
    /// </summary>
    public class Prescription
    {
        #region Properties
        public int ID { get; set; }
        public int MedicationID { get; set; }
        public int PatientID { get; set; }
        public int MedicalStaffID { get; set; }
        public int Amount { get; set; }
        public bool Extendable { get; set; }
        public DateTime? DateOfNextIssue { get; set; }
        public DateTime Date { get; set; }

        #endregion

        /// <summary>
        /// Creates the prescriptions
        /// </summary>
        public Prescription()
        {
        }
    }
}
