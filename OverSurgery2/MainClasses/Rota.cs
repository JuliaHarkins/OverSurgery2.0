using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2.Main_Classes
{
    public class Rota
    {
#region Member Variables
        List<Rota> StaffTimes = new List<Rota>();
        MetaLayer ml;
        private static Rota m_instance;
        private int m_rotaEntryID;
        private int m_medicalStaffID;
        private int m_startTime;
        private int m_endTime;
#endregion

#region Properties
        public int RotaEntryID { get { return m_rotaEntryID; } set { m_rotaEntryID = value; } }
        public int MedicalStaffID { get { return m_medicalStaffID; } set { m_medicalStaffID = value; } }
        public int StartTime { get { return m_startTime; } set { m_startTime = value; } }
        public int EndTime { get { return m_endTime; } set { m_endTime = value; } }
#endregion
        private Rota()
        {
            ml = MetaLayer.Instance();
        }

        public static Rota Instance()
        {
            if (null == m_instance)
            {
                m_instance = new Rota();
            }
            return m_instance;
        }

        /// <summary>
        /// Collect rota information from the metalayer
        /// </summary>
        /// <param name="p_rotaValues"></param>
        public Rota(Dictionary<string, object> p_rotaValues)
        {
            ml = MetaLayer.Instance();
            RotaEntryID = Convert.ToInt16(p_rotaValues["RotaID"]);
            MedicalStaffID = Convert.ToInt16(p_rotaValues["MedicalStaffID"]);
            StartTime = Convert.ToInt16(p_rotaValues["StartDateTime"]);
            EndTime = Convert.ToInt16(p_rotaValues["EndDateTime"]);
        }

        /// <summary>
        /// Create brand new rota entry
        /// </summary>
        public void AddNewRotaEntry()
        {

        }

        /// <summary>
        /// Update existing rota information
        /// </summary>
        public void UpdateRota()
        {

        }

        /// <summary>
        /// Get the rota from the metalayer
        /// </summary>
        public void GetRota()
        {
            ml.GetStaffRota();
        }
    }
}
