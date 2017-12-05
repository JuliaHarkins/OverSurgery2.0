using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgery2.UserInterface;

namespace OverSurgery2
{
    public partial class RotaForm : Form
    {
        private bool m_monSet;
        private bool m_tueSet;
        private bool m_wedSet;
        private bool m_thurSet;
        private bool m_friSet;
        private RotaFormBackEnd rfb;
        public RotaForm()
        {
            InitializeComponent();
            dG_Rota.RowHeadersVisible = false;
            rfb = new RotaFormBackEnd();
            LoadRota(rfb.LoadRota());
        }

        public void LoadRota(List<Rota> rotaData)
        {
            for (int i = 0, j = 0; j < rotaData.Count; i++, j++)
            {
                dG_Rota.Rows.Add();
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
            dG_Rota.Rows.Clear();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tuple<int, string[], bool[]> data = Update(null);
            this.Hide();
            new UpdateRota(data.Item1, data.Item2, data.Item3).ShowDialog();
            dG_Rota.Rows.Clear();
            LoadRota(rfb.LoadRota());
            this.Show();
        }

        public Tuple<int, string[], bool[]> Update(int? locale)
        {
            int rowIndex = 0;
            int staffID;
            if (locale == null)
            {
                rowIndex = dG_Rota.SelectedCells[0].RowIndex;
                staffID = (int)dG_Rota[7, rowIndex].Value;
            }
            else
            {
                staffID = (int)locale;
                for (int i = 0; i < dG_Rota.RowCount; i++)
                {
                    if (dG_Rota.Rows[i].Cells[7].Value.ToString() == locale.ToString())
                    {
                        rowIndex = (int)dG_Rota.Rows[i].Cells[7].Value - 1;
                    }
                }
            }
            string[] staffName = GetStaffData(rowIndex);
            bool[] rowStatus = GetRowData(rowIndex);

            return new Tuple<int, string[], bool[]>(staffID, staffName, rowStatus);
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
            bool[] dataSet = { m_monSet, m_tueSet, m_wedSet, m_thurSet, m_friSet};
            return dataSet;
        }

        private string[] GetStaffData(int rowIndex)
        {
            int selectedRowID = rowIndex;
            string[] staffName =
            {
                Convert.ToString(dG_Rota[0, selectedRowID].Value),
                Convert.ToString(dG_Rota[1, selectedRowID].Value)
            };
            return staffName;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RotaSearch().ShowDialog();
            dG_Rota.Rows.Clear();
            LoadRota(rfb.LoadRota());
            this.Show();
        }
    }
}