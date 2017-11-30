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
    public partial class UpdateRota : Form
    {
        private int m_staffID;
        bool[] m_rowStatus = new bool[5];
        private MetaLayer ml = MetaLayer.Instance();
        public UpdateRota(int staffID, string[] staffName, bool[] rowStatus)
        {
            InitializeComponent();
            m_staffID = staffID;
            m_rowStatus = rowStatus;
            OnLoad(staffName);
        }

        private void OnLoad(string[] staffName)
        {
            StringBuilder sb = new StringBuilder();
            staffSelected.Text = staffName[0] + " "+ staffName[1];
            if (m_rowStatus[0])
            {
                Chk_Mon.CheckState = CheckState.Checked;
                sb.Append("Monday\n");
            }
            if (m_rowStatus[1])
            {
                Chk_Tue.CheckState = CheckState.Checked;
                sb.Append("Tuesday\n");
            }
            if (m_rowStatus[2])
            {
                Chk_Wed.CheckState = CheckState.Checked;
                sb.Append("Wednesday\n");
            }
            if (m_rowStatus[3])
            {
                Chk_Thur.CheckState = CheckState.Checked;
                sb.Append("Thursday\n");
            }
            if (m_rowStatus[4])
            {
                Chk_Fri.CheckState = CheckState.Checked;
                sb.Append("Friday\n");
            }
            currentScheduleDisp.Text = sb.ToString();
        }

        private void UpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSubmit_Click(object sender, EventArgs e)
        {
            var mon = Convert.ToBoolean(Chk_Mon.CheckState);
            var tue = Convert.ToBoolean(Chk_Tue.CheckState);
            var wed = Convert.ToBoolean(Chk_Wed.CheckState);
            var thur = Convert.ToBoolean(Chk_Thur.CheckState);
            var fri = Convert.ToBoolean(Chk_Fri.CheckState);
            bool q = false;

            if (mon)
            {
                if (mon != m_rowStatus[0])
                {
                    //insert into rota values (null, 1, staffID);
                    q = ml.InsertIntoRota(1, m_staffID);
                }
            }
            else
            {
                //update rota set dayID = 6 where dayID = 1 and staffID = staffId
                q = ml.UpdateRota(1, m_staffID);
            }
            if (tue)
            {
                if (tue != m_rowStatus[1])
                {
                    //insert into rota values (null, 2, staffID);
                    q = ml.InsertIntoRota(2, m_staffID);
                }
            }
            else
            {
                //update rota set dayID = 6 where dayID = 2 and staffID = staffId
                q = ml.UpdateRota(2, m_staffID);
            }
            if (wed)
            {
                if (wed != m_rowStatus[2])
                {
                    //insert into rota values (null, 3, staffID);
                    q = ml.InsertIntoRota(3, m_staffID);
                }
            }
            else
            {
                //update rota set dayID = 6 where dayID = 3 and staffID = staffId
                q = ml.UpdateRota(3, m_staffID);
            }
            if (thur)
            {
                if (thur != m_rowStatus[3])
                {
                    //insert into rota values (null, 4, staffID);
                    q = ml.InsertIntoRota(4, m_staffID);
                }
            }
            else
            {
                //update rota set dayID = 6 where dayID = 4 and staffID = staffId
                q = ml.UpdateRota(4, m_staffID);
            }
            if (fri)
            {
                if (fri != m_rowStatus[4])
                {
                    //insert into rota values (null, 5, staffID);
                    q = ml.InsertIntoRota(5, m_staffID);
                }
            }
            else
            {
                //update rota set dayID = 6 where dayID = 5 and staffID = staffId
                q = ml.UpdateRota(5, m_staffID);
            }
            if (q)
            {
                MessageBox.Show("Complete");
            }
            else
            {
                MessageBox.Show("There was an Error Completeing the Request");
            }
            this.Close();
        }
    }
}
