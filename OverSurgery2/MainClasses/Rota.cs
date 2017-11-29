/* Created by: R
 * First Created: 31/10/17
 * Last Edit: 14/11/17 16:22
 * Last Edit by: R
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class Rota
    {
        List<Rota> StaffTimes = new List<Rota>();
        MetaLayer ml;
        private static Rota m_instance;
        private int m_rotaEntryID, m_staffID, m_startTime, m_endTime;
        private string m_forename, m_surname, m_days;

        public int RotaEntryID { get { return m_rotaEntryID; } set { m_rotaEntryID = value; } }
        public int StaffID { get { return m_staffID; } set { m_staffID = value; } }
        public int StartTime { get { return m_startTime; } set { m_startTime = value; } }
        public int EndTime { get { return m_endTime; } set { m_endTime = value; } }
        public string Forename { get { return m_forename; } set { m_forename = value; } }
        public string Surname { get { return m_surname; } set { m_surname = value; } }
        public string Days { get { return m_days; } set { m_days = value; } }


        /// <summary>
        /// Collect rota information from the metalayer
        /// </summary>
        /// <param name="p_rotaValues"></param>
        public Rota()
        {
            //ml = MetaLayer.Instance();
        }
    }
}
