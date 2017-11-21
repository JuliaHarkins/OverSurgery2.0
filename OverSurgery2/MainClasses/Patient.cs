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
    /// Patient Class, main patient object in System.
    /// </summary>
    public class Patient : Person
    {
        private int m_ID;
        private DateTime m_dateOfBirth;
        private int m_registeredDoctorID;
        private int m_gender;
        private string m_genderDisplay;
        private string m_doctorDisplay;
        private string m_phoneNumber;
        MetaLayer ml = MetaLayer.Instance();
        public int ID { get { return m_ID; } set { m_ID = value; } }
        public string DoctorDisplay { get { return m_doctorDisplay; } set { m_doctorDisplay = ml.GetMedicalStaffNameByID(m_registeredDoctorID); } }
        public int Gender { get { return m_gender; } set { m_gender = value; } }
        public string PhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
        public string GenderDisplay { get { return m_genderDisplay; } }
        public DateTime DateOfBirth
        {
            get
            {
                return m_dateOfBirth;
            }
            set
            {
                m_dateOfBirth = value;
            }
        }
        public int RegisteredDoctorID { get { return m_registeredDoctorID; } set { m_registeredDoctorID = value; } }

        public Patient()
        {
        }
        
        public void SetGenderDisplay()
        {
            if(m_gender == 1)
            {
                m_genderDisplay = "Male";
            }
            else if(m_gender == 0)
            {
                m_genderDisplay = "Female";
            }
        }


        public void SetDoctorDisplay()
        {
            m_doctorDisplay = ml.GetMedicalStaffNameByID(m_registeredDoctorID);
        }
    }
}
