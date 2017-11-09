using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery.Main_Classes;

namespace OverSurgery
{
    /// <summary>
    /// Created By: J
    /// Date Created : 31/10/17
    /// </summary>
    public class Receptionist
    {
#region Member Variables
        string m_firstName;
        string m_lastName;
        string m_email;
        int m_staffID;
        string m_username;
        string m_password;
        List<Prescription> m_extension;
#endregion
#region Properties
        List<Prescription> Extention
        {
            set
            {
                m_extension = value;
            }
        }
#endregion 
        public Receptionist(int p_staffID, string p_firstName, string p_lastName, string p_email, string p_username, string p_password)
        {

            m_firstName = p_firstName;
            m_lastName = p_lastName;
            m_email = p_email;
            m_staffID = p_staffID;
            m_username = p_username;
            m_password = p_password;

        }

        /// <summary>
        /// gives the docter a new prescription to extend.
        /// 01/11/2017 -j
        /// </summary>
        /// <param name="p_prescription"></param>
        public void AddPerscription(Prescription p_prescription)
        {
            m_extension.Add(p_prescription);
            //MetaLayer.Instance().AddPerscription(m_extension);

        }
        public void SetAppointment()
        {

        }
        public void AddPatient()
        {

        }
        public void EditPatient()
        {

        }
        public void CancelAppointment()
        {

        }
        public void RemovePatient()
        {

        }
    }
}
