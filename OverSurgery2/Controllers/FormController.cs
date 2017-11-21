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
                case 2:
                case 3:
                    new MedicalStaffForm(currentUser).ShowDialog();
                    break;
                case 4:
                    new ReceptionistForm(currentUser).ShowDialog();
                    break;
                case 5:
                    new ManagerForm(currentUser).ShowDialog();
                    break;
            }
        }

        public void SetCurrentUser(string p_username)
        {
            currentUser = ml.GetStaffByUserName(p_username);
        }

        public void OpenPatientViewForm(Patient p_Patient)
        {
            new ViewPatientInfoForm(p_Patient).ShowDialog();
        }

        public void OpenForgotPasswordForm()
        {
            new ForgotPasswordForm().ShowDialog();
        }
        
        public void OpenPasswordResetForm(Staff p_user)
        {
            new PasswordResetForm(p_user).ShowDialog();
        }

        public void OpenEditPatientForm(Patient p_Patient)
        {
            new EditPatientForm(p_Patient).ShowDialog();
        }

        public void OpenNewPatientForm()
        {
            new NewPatientForm().ShowDialog();
        }
    }
}
