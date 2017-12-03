using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace OverSurgery2.UserInterface
{
    public partial class NewAppointmentForm : Form
    {
        private NewAppointmentFormBackEnd npb;
        private string m_tables = "Staff s, Rota r", m_searchParam = "s.StaffID = ms.StaffID AND r.StaffID = s.StaffID AND r.StaffID = ms.StaffID";
        public NewAppointmentForm()
        {
            InitializeComponent();
            cbxDay.MaxDropDownItems = 7;
            cbxDay.DropDownHeight = 200;
            cbxMonth.MaxDropDownItems = 6;
            dGAppointment.RowHeadersVisible = false;
            PopulateDoctorFilter(m_tables, m_searchParam);
            PopulateDataGrid(npb.GenerateAppointmentList(DayCheck(DateTime.Now)), npb.ReturnMedicalStaff(m_tables, m_searchParam));
            PopulateYear();
            PopulateMonth();
            PopulateDay();
            DoctorFilter();
        }

        private void PopulateDoctorFilter(string tables, string searchParam)
        {
            npb = new NewAppointmentFormBackEnd();
            // Need MedicalStaffName, Gender
            // QUERY - SELECT Forename, Surname, Gender FROM Staff s, MedicalStaff ms WHERE ms.StaffID = s.StaffID ORDER BY Surname, Forename;

            // Pieces - SELECT Forename, Surname, Gender FROM {tables} WHERE {searchParam};
            //tables [staff, medicalstaff, [rota]]
            //searchParam [staffID, [dayID]]
            List<string> listOfStaff =
                npb.ReturnMedicalStaff(tables, searchParam);
            listOfStaff.Insert(0,"[Select Optional]");
            cbxDoctorFilter.DataSource = listOfStaff;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            txtPatIDSet.Text = "[Patient ID NOT SET]";
            npb = new NewAppointmentFormBackEnd();
            string forename = txtForename.Text, surname = txtSurname.Text;
            bool err = ErrorCheck(forename, surname);
            int patID;
            if (err)
            {
                List<int> patientID = npb.Selection(forename, surname);
                if (patientID != null)
                {
                    if (patientID.Count > 1)
                    {
                        this.Hide();
                        using (var form = new AppointmentConflictResolution())
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                txtPatIDSet.Text = Convert.ToString(form.PatID);
                            }
                            else
                            {
                                txtPatIDSet.Text = "[Data NOT Set]";
                            }
                        }
                        this.Show();
                    }
                    if (patientID.Count == 1)
                    {
                        patID = patientID.ElementAtOrDefault(0);
                        txtPatIDSet.Text = Convert.ToString(patID);
                    }
                }
            }
        }

        private bool ErrorCheck(string forename, string surname)
        {
            bool err = true;
            if ((forename == null) || (forename == ""))
            {
                MessageBox.Show("The Forename Box Cannot be Blank\nSorry");
                err = false;
            }
            if ((surname == null) ||(surname == ""))
            {
                MessageBox.Show("The Surname Box Cannot be Blank\nSorry");
                err = false;
            }
            return err;
        }

        private void DateFilter()
        {
            //
        }

        private void PopulateDataGrid(Tuple<List<string>, List<string>> data, List<string> medicalStaff)
        {
            dGAppointment.Rows.Clear();
            StringBuilder sb;
            for (int i = 0; i < data.Item2.Count; i++)
            {
                sb = new StringBuilder();
                foreach (string name in medicalStaff)
                {
                    string m_name = name.Remove(name.Length - 4);
                    sb.Append(m_name);
                    sb.Append(", ");
                }

                dGAppointment.Rows.Add();
                dGAppointment.Rows[i].Cells[1].Value = data.Item2.ElementAtOrDefault(i);
                dGAppointment.Rows[i].Cells[2].Value = data.Item1.ElementAtOrDefault(i);
                dGAppointment.Rows[i].Cells[3].Value = sb.ToString().Remove(sb.Length -2);
            }
        }

        private void DoctorFilter()
        {
            string staffName;
            DateTime date;
            if (cbxDay.Text != "Day")
            {
                date = Convert.ToDateTime(cbxDay.Text + "/" + cbxMonth.Text + "/" + cbxYear.Text);
            }
            else
            {
                date = DayCheck(DateTime.Now);
            }
            if (cbxDoctorFilter.Text.Contains("["))
            {
                staffName = "";
            }
            else
            {
                staffName = cbxDoctorFilter.Text;
                staffName.Remove(staffName.Length - 4);
            }
            string tables = m_tables + ", DayOfWeek d";
            string search = "";
            switch (date.DayOfWeek.ToString())
            {
                case "Monday":
                    search = "Mon";
                    break;
                case "Tuesday":
                    search = "Tue";
                    break;
                case "Wednesday":
                    search = "Wed";
                    break;
                case "Thursday":
                    search = "Thur";
                    break;
                case "Friday":
                    search = "Fri";
                    break;
            }
            string searchParam = m_searchParam + $" AND d.DayID = r.DayID AND DayName = '{search}'";
            PopulateDoctorFilter(tables, searchParam);
            PopulateDataGrid(npb.GenerateAppointmentList(date), npb.ReturnMedicalStaff(tables, searchParam));
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int patientID = 0;
            try
            {
                patientID = Convert.ToInt32(txtPatIDSet.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Patient Must be Selected");
            }
            if (patientID != 0)
            {
                int rowIndex = dGAppointment.SelectedCells[0].RowIndex;
                string date = dGAppointment.Rows[rowIndex].Cells[1].Value.ToString();
                string time = dGAppointment.Rows[rowIndex].Cells[2].Value.ToString();
                string medStaffName;
                if (dGAppointment.Rows[rowIndex].Cells[3].Value.ToString().Contains(","))
                {
                    using (var form = new MedicalStaffNewAppointmentFromConflictResolution(dGAppointment.Rows[rowIndex].Cells[3].Value.ToString()))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            txtMedStaffName.Text = Convert.ToString(form.MedicalstaffName);
                        }
                    }
                    medStaffName = txtMedStaffName.Text;
                }
                else
                {
                    medStaffName = dGAppointment.Rows[rowIndex].Cells[3].Value.ToString();
                }
                string notes = Interaction.InputBox("Add Notes (If Applicable)?", "Notes");
                bool flg = npb.InsertAppointment(patientID, date, time, notes, medStaffName);

                if (flg)
                {
                    MessageBox.Show("Appointment Saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There has been an error with the request");
                }
            }
        }

        private void PopulateDay()
        {
            int currentDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            List<string> day = new List<string>();
            if (cbxMonth.Text == "Month")
            {
            }
            else if (cbxMonth.Text == DateTime.Now.ToString("MM"))
            {
                for (int i = currentDay; i <= DateTime.DaysInMonth(Convert.ToInt32(cbxYear.Text), Convert.ToInt32(cbxMonth.Text)); i++)
                {
                    string dayToCheck = i + "/" + cbxMonth.Text + "/" + cbxYear.Text;
                    if (DateTime.Parse(dayToCheck).DayOfWeek.ToString() != "Saturday")
                    {
                        if (DateTime.Parse(dayToCheck).DayOfWeek.ToString() != "Sunday")
                        {
                            day.Add(i.ToString());
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(cbxYear.Text), Convert.ToInt32(cbxMonth.Text)); i++)
                {
                    string dayToCheck = i + "/" + cbxMonth.Text + "/" + cbxYear.Text;
                    if (DateTime.Parse(dayToCheck).DayOfWeek.ToString() != "Saturday")
                    {
                        if (DateTime.Parse(dayToCheck).DayOfWeek.ToString() != "Sunday")
                        {
                            day.Add(i.ToString());
                        }
                    }
                }
            }
            day.Insert(0, "Day");
            cbxDay.DataSource = day;
        }

        private DateTime DayCheck(DateTime currentDate)
        {
            DateTime date;
            if (currentDate.DayOfWeek.ToString() != "Saturday")
            {
                if (currentDate.DayOfWeek.ToString() != "Sunday")
                {
                    date = currentDate;
                }
                else
                {
                    int day = Convert.ToInt32(currentDate.ToString("dd")) + 1;
                    date = DateTime.Parse(day + "/" + currentDate.ToString("MM") + "/" + currentDate.ToString("yyyy"));
                }
            }
            else
            {
                int day = Convert.ToInt32(currentDate.ToString("dd")) + 2;
                date = DateTime.Parse(day + "/" + currentDate.ToString("MM") + "/" + currentDate.ToString("yyyy"));
            }
            return date;
        }

        private void PopulateMonth()
        {
            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            List<string> month = new List<string>();
            if (cbxYear.Text == "Year")
            {
            }
            else if (cbxYear.Text == DateTime.Now.ToString("yyyy"))
            {
                for (int i = currentMonth; i <= 12; i++)
                {
                    month.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    month.Add(i.ToString());
                }
            }
            month.Insert(0, "Month");
            cbxMonth.DataSource = month;
        }

        private void cbxYear_DropDownClosed(object sender, EventArgs e)
        {
            PopulateMonth();
            PopulateDay();
        }

        private void cbxMonth_DropDownClosed(object sender, EventArgs e)
        {
            PopulateDay();
        }

        private void cbxDay_DropDownClosed(object sender, EventArgs e)
        {
            DoctorFilter();
        }

        private void cbxDoctorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void cbxDoctorFilter_DropDownClosed(object sender, EventArgs e)
        {
            //
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMonth();
            PopulateDay();
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDay();
        }

        private void PopulateYear()
        {
            int year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            List<string> yearToDisp = new List<string>();
            yearToDisp.Add("Year");
            yearToDisp.Add(year.ToString());
            yearToDisp.Add((year+1).ToString());
            cbxYear.DataSource = yearToDisp;
        }
    }
}
