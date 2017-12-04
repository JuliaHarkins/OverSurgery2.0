using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2.UserInterface
{
    class NewAppointmentFormBackEnd
    {
        public class TimeSheet
        {
            public DateTime AppDate {get;set;}
            public DateTime AppTime {get;set;}
        }

        private List<TimeSheet> GenerateTimeSheet(DateTime date)
        {
            TimeSheet ts;
            List<TimeSheet> returnData = new List<TimeSheet>();

            for (int i = 9; i < 17; i++)
            {
                for (int j = 0; j < 60; j += 15)
                {
                    ts = new TimeSheet
                    {
                        AppTime = Convert.ToDateTime(i.ToString() + ":" + j.ToString() + ":00"),
                        AppDate = date,
                    };
                    returnData.Add(ts);
                }
            }
            return returnData;
        }
        MetaLayer ml = MetaLayer.Instance();
        public List<int> Selection(string forename, string surname)
        {
            string searchParam = $"Forename = '{forename}' AND Surname = '{surname}'";
            List<int> returnData = ml.SelectPatient(searchParam);
            return returnData;
        }

        public Tuple<List<int>, List<string>, List<string>, List<string>> SelectPatientAddress(string forename, string surname)
        {
            string searchParam = $"Forename = '{forename}' AND Surname = '{surname}'";

            Tuple<List<int>, List<string>, List<string>, List<string>, List<int>, List<string>, List<string>>
                returnData = ml.SelectPatientAddress(searchParam);

            List<int> patientID = returnData.Item1;
            List<string> m_forename = returnData.Item2;
            List<string> m_surname = returnData.Item3;
            List<string> address = new List<string>();

            for (int i = 0; i < returnData.Item4.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                if (returnData.Item5.ElementAtOrDefault(i) == 0)
                {
                    sb.Append(returnData.Item4.ElementAtOrDefault(i) + " ");
                }
                else
                {
                    sb.Append(returnData.Item5.ElementAtOrDefault(i) + " ");
                }
                sb.Append(returnData.Item6.ElementAtOrDefault(i) + " ");
                sb.Append(returnData.Item7.ElementAtOrDefault(i));

                address.Add(sb.ToString());
            }

            return new Tuple<List<int>, List<string>, List<string>, List<string>>(patientID, m_forename, m_surname, address);
        }

        public List<string> ReturnMedicalStaff(string tables, string searchParam)
        {
            Tuple<List<string>, List<string>, List<string>> returnData = ml.SelectMedicalStaff_WithDateAddOn(tables, searchParam);
            StringBuilder sb;
            List<string> staffData = new List<string>();

            for (int i = 0; i < returnData.Item1.Count; i++)
            {
                sb = new StringBuilder();
                sb.Append(returnData.Item1.ElementAtOrDefault(i));
                sb.Append(" ");
                sb.Append(returnData.Item2.ElementAtOrDefault(i));
                sb.Append(" (");
                sb.Append(returnData.Item3.ElementAtOrDefault(i));
                sb.Append(")");
                staffData.Add(sb.ToString());
            }

            return staffData;
        }

        public bool InsertAppointment(int patientID, string date, string time, string notes, string medStaffName)
        {
            int dateInt = Convert.ToInt32(DateTime.Parse(date).ToString("yyyyMMdd"));
            int timeInt = Convert.ToInt32(DateTime.Parse(time).ToString("HHmmss"));
            medStaffName = medStaffName.TrimEnd(' ');
            medStaffName = medStaffName.TrimStart(' ');
            string[] split = medStaffName.Split(' ');
            string forename = split[0];
            string surname = split[1];
            string searchParam = $" ms, Staff s WHERE Forename = '{forename}' AND Surname = '{surname}' AND ms.StaffID = s.StaffID";
            List<int> medStaffID = ml.GetMedicalStaffID(searchParam);
            int medStaffIDInt = medStaffID.ElementAtOrDefault(0);

            bool flag = ml.AddAppointment(dateInt, timeInt, notes, medStaffIDInt, patientID);

            return flag;
        }
        /// <summary>
        /// Generates all possible Appointments
        /// </summary>
        /// <param name="staffName"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateUntil"></param>
        /// <returns></returns>
        public Tuple<List<string>, List<string>> GenerateAppointmentList(DateTime date)
        {
            List<TimeSheet> fullSpec = GenerateTimeSheet(date);
            List<string> time = new List<string>();
            List<string> l_date = new List<string>();
            for (int j = 0; j < fullSpec.Count; j++)
            {
                time.Add(fullSpec.ElementAtOrDefault(j).AppTime.ToString("HH:mm:ss"));
                l_date.Add(fullSpec.ElementAtOrDefault(j).AppDate.ToString("dd/MM/yyyy"));
            }
            return new Tuple<List<string>, List<string>>(time, l_date);
        }
        // Filters Medical Staff based on dates given and working hours
    }
}
