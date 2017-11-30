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
    public partial class RotaSearch : Form
    {
        MetaLayer ml =  MetaLayer.Instance();
        public RotaSearch()
        {
            InitializeComponent();
            dG_Suggested.RowHeadersVisible = false;
        }

        private void Find()
        {
            dG_Suggested.Rows.Clear();
            bool flg = true;
            string forename = txtBxForename.Text, surname = txtBxSurname.Text, searchParam = "";

            if ((forename == null && surname == null) || (forename == "" && surname == ""))
            {
                flg = false;
                MessageBox.Show("Please Enter Staff Name");
            }
            else if ((forename != null && surname == null) || (forename != "" && surname == ""))
            {
                searchParam = $"Forename = '{forename}'";
            }
            else if ((forename == null && surname != null) || (forename == "" && surname != ""))
            {
                searchParam = $"Surname = '{surname}'";
            }
            else
            {
                searchParam = $"Forename = '{forename}' AND Surname = '{surname}'";
            }
            if (flg)
            {
                Display(
                ml.SearchRota(searchParam).Item1,
                ml.SearchRota(searchParam).Item2,
                ml.SearchRota(searchParam).Item3,
                ml.SearchRota(searchParam).Item4
                );
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            txtDispMon.Text = 
            txtDispTue.Text = 
            txtDispWed.Text = 
            txtDispThur.Text =
            txtDispFri.Text = "[Insert Data]";
            Find();
        }

        private void Display(List<int> staffID, List<string> forename, List<string> surname, List<string> days)
        {
            if (staffID.Count == 1)
            {
                string dataToDisplay = days.ElementAtOrDefault(0);
                if (dataToDisplay.Contains("Mon"))
                {
                    txtDispMon.Text = "Working";
                }
                if (dataToDisplay.Contains("Tue"))
                {
                    txtDispTue.Text = "Working";
                }
                if (dataToDisplay.Contains("Wed"))
                {
                    txtDispWed.Text = "Working";
                }
                if (dataToDisplay.Contains("Thur"))
                {
                    txtDispThur.Text = "Working";
                }
                if (dataToDisplay.Contains("Fri"))
                {
                    txtDispFri.Text = "Working";
                }
            }
            else
            {
                for (int i = 0; i < staffID.Count; i++)
                {
                    dG_Suggested.Rows.Add(staffID.ElementAtOrDefault(i), forename.ElementAtOrDefault(i), surname.ElementAtOrDefault(i));
                    dG_Suggested.Refresh();
                }
            }
        }

        private void Running_DisplayMethod_FromDatagrid()
        {
            txtDispMon.Text =
            txtDispTue.Text =
            txtDispWed.Text =
            txtDispThur.Text =
            txtDispFri.Text = "[Insert Data]";
            int rowIndex = Convert.ToInt32(dG_Suggested.SelectedCells[0].RowIndex);
            int staffID = Convert.ToInt32(dG_Suggested.Rows[rowIndex].Cells["StaffID"].Value);
            if (staffID != 0)
            {
                string searchParam = $"s.StaffID = '{staffID}'";
                Display(
                    ml.SearchRota(searchParam).Item1,
                    ml.SearchRota(searchParam).Item2,
                    ml.SearchRota(searchParam).Item3,
                    ml.SearchRota(searchParam).Item4
                );
            }
            else
            {
                MessageBox.Show("No Row Selected");
            }
        }

        private void dG_Suggested_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Running_DisplayMethod_FromDatagrid();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClearDisp_Click(object sender, EventArgs e)
        {
            dG_Suggested.Rows.Clear();
            txtDispMon.Text =
            txtDispTue.Text =
            txtDispWed.Text =
            txtDispThur.Text =
            txtDispFri.Text = "[Insert Data]";
            txtBxForename.Text = 
            txtBxSurname.Text = null;
        }
    }
}
