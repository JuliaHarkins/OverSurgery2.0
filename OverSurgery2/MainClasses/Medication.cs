using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
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
        private string m_dosage;
#endregion
#region Constructors
        public Medication()
        {
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
        public string Dosage
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
        public void CheckPermission()
        {
            // GetPermission_Staff

            //GetPermission_Medication

            //Compare on med.permission <= staff.permission
        }
    }
}
