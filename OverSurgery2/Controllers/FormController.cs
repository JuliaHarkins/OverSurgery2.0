using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class FormController
    {
        Staff currentUser;
        private static FormController m_getInstance;
        MetaLayer ml;
        private FormController()
        {
            ml = MetaLayer.Instance();
        }
        public static FormController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new FormController();
            }
            return m_getInstance;
        }
        public void OpenMainForm()
        {
            Dictionary<Type, int> StaffTypes = new Dictionary<Type, int>
            {
                {typeof(MedicalStaff),1 },
                {typeof(Locum),2},
                {typeof(Doctor), 3},
                {typeof(Receptionist),4},
                {typeof(Manager), 5 }
            };

            switch(StaffTypes[currentUser.GetType()])
            {
                case 1:
                    new MedicalStaffForm(currentUser);
                    break;
                case 2:
                    break;
                case 3:
                    new MedicalStaffForm(currentUser);
                    break;
                case 4:
                    new ReceptionistForm(currentUser);
                    break;
                case 5:
                    new ManagerForm(currentUser);
                    break;
            }
        }

        public void SetCurrentUser(string p_username)
        {
            currentUser = ml.GetStaffByUserName(p_username);
        }

        public void OpenPatientViewForm(Patient p_Patient)
        {
            new ViewPatientInfoForm(p_Patient);
        }

        public void OpenForgotPasswordForm()
        {
            new ForgotPasswordForm();
        }
        
        public void OpenPasswordResetForm(Staff p_user)
        {
            new PasswordResetForm(p_user);
        }

        public void OpenEditPatientForm(Patient p_Patient)
        {
            new EditPatientForm(p_Patient);
        }

        public void OpenNewPatientForm()
        {
            new NewPatientForm();
        }
    }
}
