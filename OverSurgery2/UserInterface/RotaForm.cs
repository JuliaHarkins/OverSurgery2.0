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
    public partial class RotaForm : Form
    {
        private bool m_monSet;
        private bool m_tueSet;
        private bool m_wedSet;
        private bool m_thurSet;
        private bool m_friSet;
        private List<int> m_staffID = new List<int>();
        private List<Rota> rotaData;
        MetaLayer ml;
        public RotaForm()
        {
            InitializeComponent();
            dG_Rota.RowHeadersVisible = false;
            LoadRota();
        }

        public void LoadRota()
        {
            ml = MetaLayer.Instance();
            rotaData = ml.GetStaffRota();

            for (int i = 0, j = 0; j < rotaData.Count; i++, j++)
            {
                dG_Rota.Rows.Add();
                m_staffID.Add(rotaData.ElementAtOrDefault(j).StaffID);
                dG_Rota[0, i].Value = rotaData.ElementAtOrDefault(j).Forename;
                dG_Rota[1, i].Value = rotaData.ElementAtOrDefault(j).Surname;
                if (rotaData.ElementAtOrDefault(i).Days.Contains("Mon"))
                {
                    dG_Rota[2, i].Style.BackColor = Color.Green;
                }
                else
                {
                    dG_Rota[2, i].Style.BackColor = Color.Red;
                }
                if (rotaData.ElementAtOrDefault(i).Days.Contains("Tue"))
                {
                    dG_Rota[3, i].Style.BackColor = Color.Green;
                }
                else
                {
                    dG_Rota[3, i].Style.BackColor = Color.Red;
                }
                if (rotaData.ElementAtOrDefault(i).Days.Contains("Wed"))
                {
                    dG_Rota[4, i].Style.BackColor = Color.Green;
                }
                else
                {
                    dG_Rota[4, i].Style.BackColor = Color.Red;
                }
                if (rotaData.ElementAtOrDefault(i).Days.Contains("Thur"))
                {
                    dG_Rota[5, i].Style.BackColor = Color.Green;
                }
                else
                {
                    dG_Rota[5, i].Style.BackColor = Color.Red;
                }
                if (rotaData.ElementAtOrDefault(i).Days.Contains("Fri"))
                {
                    dG_Rota[6, i].Style.BackColor = Color.Green;
                }
                else
                {
                    dG_Rota[6, i].Style.BackColor = Color.Red;
                }
                dG_Rota[7, i].Value = rotaData.ElementAtOrDefault(j).StaffID;
                dG_Rota.Sort(dG_Rota.Columns[7], ListSortDirection.Ascending);
                dG_Rota.Columns[7].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rotaData.Clear();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dG_Rota.SelectedCells[0].RowIndex;
            int staffID = m_staffID.ElementAtOrDefault(Convert.ToInt32(dG_Rota[7, rowIndex].Value) -1);
            string[] staffName = GetStaffData(rowIndex);
            bool[] rowStatus = GetRowData(rowIndex);
            this.Hide();
            new UpdateRota(staffID, staffName, rowStatus).ShowDialog();
            dG_Rota.Rows.Clear();
            LoadRota();
            this.Show();
        }

        private bool[] GetRowData(int rowIndex)
        {
            
            int selectedRowID = rowIndex;
            if (dG_Rota[2, selectedRowID].Style.BackColor == Color.Green)
            {
                m_monSet = true;
            }
            else
            {
                m_monSet = false;
            }
            if (dG_Rota[3, selectedRowID].Style.BackColor == Color.Green)
            {
                m_tueSet = true;
            }
            else
            {
                m_tueSet = false;
            }
            if (dG_Rota[4, selectedRowID].Style.BackColor == Color.Green)
            {
                m_wedSet = true;
            }
            else
            {
                m_wedSet = false;
            }
            if (dG_Rota[5, selectedRowID].Style.BackColor == Color.Green)
            {
                m_thurSet = true;
            }
            else
            {
                m_thurSet = false;
            }
            if (dG_Rota[6, selectedRowID].Style.BackColor == Color.Green)
            {
                m_friSet = true;
            }
            else
            {
                m_friSet = false;
            }
            bool[] dataSet = new bool[5] { m_monSet, m_tueSet, m_wedSet, m_thurSet, m_friSet};
            return dataSet;
        }

        private string[] GetStaffData(int rowIndex)
        {
            int selectedRowID = rowIndex;
            string[] staffName = new string[2]
            {
                Convert.ToString(dG_Rota[0, selectedRowID].Value),
                Convert.ToString(dG_Rota[1, selectedRowID].Value)
            };
            return staffName;
        }
    }
}
