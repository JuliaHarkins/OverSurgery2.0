using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 20/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: E
    /// </summary>
    public class Medication
    {
#region Member Variables
        private uint? m_id;
        private string m_medicationName;
        private uint? m_permissionLevel;
        private uint? m_dosage;
#endregion
#region Constructors
        public Medication(Dictionary<string, object> p_medicationData)
        {
            m_id = Convert.ToUInt16(p_medicationData["MedicationID"]);
            m_medicationName = Convert.ToString(p_medicationData["MedicationName"]);
            m_permissionLevel = Convert.ToUInt16(p_medicationData["PermissionLevel"]);
            m_dosage = Convert.ToUInt16(p_medicationData["Dosage"]);
        }
#endregion
#region Properties
        public string Name
        {
            get
            {
                return m_medicationName;
            }
            set
            {
                m_medicationName = value;
            }
        }
        public uint? PermissionLevel
        {
            get
            {
                return m_permissionLevel;
            }
            set
            {
                m_permissionLevel = value;
            }
        }
        public uint? ID
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
        public uint? Dosage
        {
            get
            {
                return m_dosage;
            }
            set
            {
                m_dosage = value;
            }
        }
#endregion
    }
}
