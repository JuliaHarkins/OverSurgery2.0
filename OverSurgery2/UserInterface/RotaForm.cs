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
            //
        }
    }
}
