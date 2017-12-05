using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2.UserInterface
{
    public partial class AppointmentConflictResolution : Form
    {
        private bool m_closeFlag = true;
        public int PatID { get; set; }
        private bool CloseFlag { get { return m_closeFlag; } set { m_closeFlag = value; }}
        private string forename { get; set; }
        private string surname { get; set; }
        private NewAppointmentFormBackEnd npb;
        public AppointmentConflictResolution(string p_forename, string p_surname)
        {
            InitializeComponent();
            dGConflict.RowHeadersVisible = false;
            forename = p_forename;
            surname = p_surname;
        }

        private void AppointmentConflictResolution_Load(object sender, EventArgs e)
        {
            npb = new NewAppointmentFormBackEnd();
            PopulateDataGrid(npb.SelectPatientAddress(forename, surname));
        }

        private void PopulateDataGrid(Tuple<List<int>, List<string>, List<string>, List<string>> data)
        {
            dGConflict.Rows.Clear();
            for (int i = 0;i < data.Item1.Count; i++)
            {
                dGConflict.Rows.Add();
                dGConflict.Rows[i].Cells[0].Value = data.Item1.ElementAtOrDefault(i);
                dGConflict.Rows[i].Cells[1].Value = data.Item2.ElementAtOrDefault(i);
                dGConflict.Rows[i].Cells[2].Value = data.Item3.ElementAtOrDefault(i);
                dGConflict.Rows[i].Cells[3].Value = data.Item4.ElementAtOrDefault(i);
            }
        }

        private void AppointmentConflictResolution_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag)
            {
                e.Cancel = true;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int rowIndex = dGConflict.SelectedCells[0].RowIndex;
            this.PatID = (int)dGConflict.Rows[rowIndex].Cells[0].Value;
            this.DialogResult = DialogResult.OK;
            CloseFlag = false;
            this.Close();
        }
    }
}
