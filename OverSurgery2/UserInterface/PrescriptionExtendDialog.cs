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
    public partial class PrescriptionExtendDialog : Form
    {
        private Prescription m_extendPres;
        public PrescriptionExtendDialog(Prescription p_Prescription)
        {
            m_extendPres = p_Prescription;
            InitializeComponent();
        }

        private void PrescriptionExtendDialog_Load(object sender, EventArgs e)
        {
            cbx_Months.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            if (!(m_extendPres.DateOfNextIssue <= DateTime.Now))
            {
                MessageBox.Show("This prescription cannot be extended yet, \nplease wait until " + m_extendPres.DateOfNextIssue.Value.ToShortDateString() + "" +
                    "to extend this prescription.");
            }
            else if (!m_extendPres.Extendable)
            {
                MessageBox.Show("This prescription cannot be extended. Please refer the patient to their GP.");
            }
            else
            {
                MessageBox.Show(Convert.ToInt32(cbx_Months.SelectedItem.ToString()).ToString());
            }
        }
    }
}
