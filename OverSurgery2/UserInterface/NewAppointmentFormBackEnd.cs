using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    class NewAppointmentFormBackEnd
    {
        private class TimeSheet
        {
            public DateTime AppDate {get;set;}
            public DateTime AppTime {get;set;}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        public List<int> Selection(string forename, string surname)
        {
            string searchParam = $"Forename = '{forename}' AND Surname = '{surname}'";
            List<int> returnData = ml.SelectPatient(searchParam);
            return returnData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        /// <param name="searchParam"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="notes"></param>
        /// <param name="medStaffName"></param>
        /// <returns></returns>
        public int InsertAppointment(int patientID, string time, string date, string notes, string medStaffName)
        {
            int flg = 0;
            int flag = 3;
            int dateInt = Convert.ToInt32(DateTime.Parse(date).ToString("yyyyMMdd"));
            int timeInt = Convert.ToInt32(DateTime.Parse(time).ToString("HHmmss"));
            medStaffName = medStaffName.TrimEnd(' ');
            medStaffName = medStaffName.TrimStart(' ');
            string[] split = medStaffName.Split(' ');
            string forename = split[0];
            string surname = split[1];
            string searchParam = $" ms, Staff s WHERE Forename = '{forename}' AND Surname = '{surname}' AND ms.StaffID = s.StaffID";
            List<int> medStaffID = GetMedicalStaffID(searchParam);
            int medStaffIDInt = medStaffID.ElementAtOrDefault(0);

            string checkParam = $"AppointmentDate = {dateInt} AND AppointmentTime = {timeInt} AND PatientID = {patientID}";
            flg = ml.AppointmentCheck(checkParam);

            if (flg != 0)
            {
                flag = ml.AddAppointment(dateInt, timeInt, notes, medStaffIDInt, patientID);
            }
            else
            {
                flag = flg;
            }

            return flag;
        }

        private List<int> GetMedicalStaffID(string searchParam)
        {
            return ml.GetMedicalStaffID(searchParam);
        }

        private List<int> GetCurrentAppointments(DateTime date, int appointmentTime)
        {
            string data = "MedicalStaffID";
            int dbDate = Convert.ToInt32(date.ToString("yyyyMMdd"));
            string searchParam = $"AppointmentDate = {dbDate} AND AppointmentTime = {appointmentTime}";
            return ml.SelectCurrentAppointments(data, searchParam);
        }

        private string DayConvert(string day)
        {
            string dayConv;
            switch (day)
            {
                case "Monday":
                    dayConv = "Mon";
                    break;
                case "Tuesday":
                    dayConv = "Tue";
                    break;
                case "Wednesday":
                    dayConv = "Wed";
                    break;
                case "Thursday":
                    dayConv = "Thur";
                    break;
                case "Friday":
                    dayConv = "Fri";
                    break;
                default:
                    dayConv = "Default";
                    break;
            }
            return dayConv;
        }
        public Tuple<List<string>, List<string>, List<string>> SequenceAppointments(DateTime date, string doctorFilter)
        {
            Tuple<List<string>, List<string>> generatedTimeSheet = GenerateAppointmentList(date);

            string dayName = DayConvert(date.DayOfWeek.ToString());

            List<int> time = new List<int>();
            for (int i = 0; i < generatedTimeSheet.Item1.Count; i++)
            {
                time.Add(Convert.ToInt32(DateTime.Parse(generatedTimeSheet.Item1.ElementAtOrDefault(i)).ToString("HHmmss")));
            }
            List<List<int>> temp = new List<List<int>>();
            for (int j = 0; j < time.Count; j++)
            {
                List<int> allMedicalStaffWorking = GetMedicalStaffID($"  ms, Rota r, Staff s, DayOfWeek d WHERE ms.StaffID = r.StaffID AND ms.StaffID = s.StaffID AND s.StaffID = r.StaffID AND r.DayID = d.DayID AND DayName = '{dayName}'{doctorFilter}");
                List<int> medicalStaffID = GetCurrentAppointments(date, time.ElementAtOrDefault(j));

                for (int q = 0; q < allMedicalStaffWorking.Count; q++)
                {
                    for (int k = 0; k < medicalStaffID.Count; k++)
                    {
                        if (allMedicalStaffWorking.ElementAtOrDefault(q).Equals(medicalStaffID.ElementAtOrDefault(k)))
                        {
                            allMedicalStaffWorking.RemoveAt(q);
                            q--;
                        }
                    }
                }
                temp.Add(allMedicalStaffWorking);
            }

            List<string> staffAvailable = new List<string>();
            for (int q = 0; q < temp.Count; q++)
            {
                List<string> name = new List<string>();
                for (int w = 0; w < temp.ElementAtOrDefault(q).Count; w++)
                {
                    name.Add(ml.ReturnMedicalStaffName(temp.ElementAtOrDefault(q).ElementAtOrDefault(w)));
                }
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < name.Count; j++)
                {
                    sb.Append(name.ElementAtOrDefault(j));
                    sb.Append(", ");
                }
                staffAvailable.Add(sb.ToString());
            }
            return new Tuple<List<string>, List<string>, List<string>>(generatedTimeSheet.Item2, generatedTimeSheet.Item1, staffAvailable);
        }

        /// <summary>
        /// Generates all possible Appointments
        /// </summary>
        /// <param name="staffName"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateUntil"></param>
        /// <returns></returns>
        private Tuple<List<string>, List<string>> GenerateAppointmentList(DateTime date)
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
