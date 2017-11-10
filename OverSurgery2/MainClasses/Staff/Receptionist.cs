using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery2.Main_Classes;

namespace OverSurgery2
{
    /// <summary>
    /// Created By: J
    /// Date Created : 31/10/17
    /// </summary>
    public class Receptionist : Staff
    {
#region Member Variables
        string m_Forename;
        string m_Surname;
        string m_email;
        int m_staffID;
        string m_username;
        string m_password;
        List<Prescription> m_extension;
        FormController fc = FormController.Instance();
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

        public Receptionist(Dictionary<string, object> p_PersonValues) :base(p_PersonValues)
        {
            
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
