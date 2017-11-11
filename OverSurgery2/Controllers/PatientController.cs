using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class PatientController
    {
        /// <summary>
        /// Created By: J
        /// Date Created : 31/10/17
        /// </summary>
        MetaLayer ml = MetaLayer.Instance();
        public List<Patient> patients;
        private static PatientController m_getInstance;
        PersonFactory pf = PersonFactory.Instance();
        private PatientController()
        {
            patients = ml.getPatients();
        }
        public static PatientController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new PatientController();
            }
            return m_getInstance;
        }

        public void AddNewPatient(Dictionary<string,object> p_PatientValues)
        {
            patients.Add(pf.CreatePatient(p_PatientValues));
            ml.InsertNewPatient(p_PatientValues);
        }

        public void UpdatePatientDoctorDisplay()
        {
            foreach(Patient p in patients)
            {
                p.SetDoctorDisplay();
            }
        }
    }
}