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
    public partial class ManagerForm : Form
    {
        BindingSource StaffBinding;
        BindingSource RotaBinding;
        Staff currentUserLoggedIn = null;
        MetaLayer ml = MetaLayer.Instance();
        FormController fc = FormController.Instance();
        public ManagerForm()
        {
            InitializeComponent();
        }
    }
}
