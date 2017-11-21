using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Created By: J
    /// Date Created : 31/10/17
    /// </summary>
    public class MedicalHistory
    {
#region Members
        int? m_id;
        DateTime m_date;
        string m_notes;
       int  m_patientID;
#endregion
#region Properties
        public int? ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return m_date;
            }
            set
            {
                m_date = value;
            }
        }
        public string Notes
        {
            get
            {
                return m_notes;
            }
            set
            {
                m_notes = value;
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
        #endregion
#region Constructor
        public MedicalHistory()
        {
        }
    }
#endregion
}


