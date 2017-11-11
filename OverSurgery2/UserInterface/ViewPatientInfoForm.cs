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
    public partial class ViewPatientInfoForm : Form
    {
        Patient currentPatient;
        MetaLayer ml = MetaLayer.Instance();
        FormController fc = FormController.Instance();
        public ViewPatientInfoForm(Patient p_Patient)
        {
            currentPatient = p_Patient;
            InitializeComponent();
            LoadPatientInfo();
            this.Show();
        }

        public void LoadPatientInfo()
        {
            this.Text = "Viewing Patient - " + currentPatient.Forename + " " +currentPatient.Surname;
            lbl_Forename.Text = currentPatient.Forename;
            lbl_Surname.Text = currentPatient.Surname;
            lbl_address.Text = ml.GetAddressByID(Convert.ToInt16(currentPatient.AddressID));

        }

        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            fc.OpenEditPatientForm(currentPatient);
        }
    }
}
