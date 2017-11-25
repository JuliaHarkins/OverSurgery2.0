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
            List<Rota> rotaData = ml.GetStaffRota();
            MessageBox.Show(rotaData.ElementAtOrDefault(0).Forename + "\n" + rotaData.ElementAtOrDefault(0).Surname + "\n" + rotaData.ElementAtOrDefault(0).Days);

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
            }
        }
    }
}
