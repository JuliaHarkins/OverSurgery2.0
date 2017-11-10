using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Created By: J
 * Date Created : 1/11/17
 *  this object is used to hold all information needed for a perscription,
 *   and allow for their extention
 */

namespace OverSurgery.Main_Classes
{
    /// <summary>
    /// this object is used to hold all information needed for a perscription,
    ///and allow for their extention.
    /// </summary>
    public class Prescription
    {
#region member Varibles 
        int m_medicationID; 
        int m_patientID;
        int m_extentionCouter;
        int m_maxExtention;
        DateTime m_dateMade;
        DateTime m_enddate;
        string m_dose;
        int m_staffID;
#endregion

        /// <summary>
        /// creates the percription object.  
        /// 01/11/2017 -J
        /// </summary>
        /// <param name="p_medicationID">holds the id for the medication</param>
        /// <param name="p_patientID">holds the patients id</param>
        /// <param name="p_endDate">holds the date the perscription ends</param>
        /// <param name="p_dose">when and how much medication to take</param>
        /// <param name="p_staffID">the id of the person who perscribed it.</param>
#region Constructor
        public Prescription(int p_medicationID, int p_patientID,int p_maxExtention, DateTime p_endDate, string p_dose, int p_staffID)
        {
            m_medicationID = p_medicationID;
            m_patientID = p_patientID;
            m_enddate = p_endDate;
            m_dose = p_dose;
            m_staffID = p_staffID;
            m_dateMade = DateTime.Now;
            m_maxExtention = p_maxExtention;
        }
#endregion
#region Methods
        /// <summary>
        /// extents the perscription by one month
        /// </summary>
        public void Extend()
        {
#region Execution
            if (m_maxExtention > m_extentionCouter) {
                m_enddate.AddMonths(1);
                m_extentionCouter++;
            }
#endregion
        }
        /// <summary>
        /// extends by a given amount of months.
        /// </summary>
        /// <param name="p_months"></param>
        public void Extend(int p_months)
        {
#region Execution
            int addMonth = m_extentionCouter + p_months;
            if ( addMonth<= m_maxExtention)
            {
                m_enddate.AddMonths(addMonth);
                m_extentionCouter += addMonth;
            }
#endregion
        }
#endregion

    }
}
