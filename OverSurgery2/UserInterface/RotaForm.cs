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

            for (int i = 1; i < rotaData.Count; i++)
            {
                dG_Rota[0, i].Value = rotaData.ElementAt(i).Forename;
                dG_Rota[1, i].Value = rotaData.ElementAt(i).Surname;
                if (rotaData.ElementAt(i).Days.Contains("Mon"))
                {
                    dG_Rota[2, i].Style.BackColor = Color.Green;
                }
                else if (rotaData.ElementAt(i).Days.Contains("Tue"))
                {

                }
                else if (rotaData.ElementAt(i).Days.Contains("Wed"))
                {

                }
                else if (rotaData.ElementAt(i).Days.Contains("Thur"))
                {

                }
                else if (rotaData.ElementAt(i).Days.Contains("Fri"))
                {

                }
                else
                {

                }
            }
        }
    }
}
