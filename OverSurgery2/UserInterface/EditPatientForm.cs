using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery
{
    public partial class EditPatientForm : Form
    {
        Patient m_currentPatient;
        MetaLayer ml = MetaLayer.Instance();
        public EditPatientForm(int p_patientID)
        {
            InitializeComponent();
            m_currentPatient = ml.GetPatientByID(p_patientID);
            LoadCurrentPatientInfo();
            this.ShowDialog();
        }

        private void LoadCurrentPatientInfo()
        {
            txt_FirstName.Text = m_currentPatient.FirstName;
            txt_LastName.Text = m_currentPatient.LastName;
        }

    }
}
