using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2
{
    public partial class EditPatientForm : Form
    {
        Patient m_currentPatient;
        public EditPatientForm(Patient p_Patient)
        {
            InitializeComponent();
            m_currentPatient = p_Patient;
            LoadCurrentPatientInfo();
            this.ShowDialog();
        }

        private void LoadCurrentPatientInfo()
        {
            txt_Forename.Text = m_currentPatient.Forename;
            txt_Surname.Text = m_currentPatient.Surname;
        }

    }
}
