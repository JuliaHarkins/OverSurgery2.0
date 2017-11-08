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
    public partial class ViewPatientInfoForm : Form
    {
        private int selectedPatient;
        MetaLayer ml = MetaLayer.Instance();
        FormController fc = FormController.Instance();
        public ViewPatientInfoForm(int p_id)
        {
            InitializeComponent();
            selectedPatient = p_id;
            LoadPatientInfo();
            this.Show();
        }

        public void LoadPatientInfo()
        {
            Patient currentPatient = ml.GetPatientByID(selectedPatient);
            this.Text = "Viewing Patient - " + currentPatient.FirstName + " " +currentPatient.LastName;
            lbl_FirstName.Text = currentPatient.FirstName;
            lbl_LastName.Text = currentPatient.LastName;
            lbl_address.Text = ml.GetAddressByID(currentPatient.Address);

        }

        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            fc.OpenEditPatientForm(selectedPatient);
        }
    }
}
