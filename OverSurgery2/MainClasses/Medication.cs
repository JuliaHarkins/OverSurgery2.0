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
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// </summary>
    public class Medication
    {
#region Member Variables
        private int m_id;
        private string m_name;
        private int m_permissionLevel;

        public string Name { get { return m_name; } set { m_name = value; } }
        public int PermissionLevel { get { return m_permissionLevel; } set { m_permissionLevel = value; } }
        public int ID { get { return m_id; } set { m_id = value; } }
#endregion
#region Constructors
#endregion
    }
}
