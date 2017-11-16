using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using OverSurgery2.Main_Classes;

namespace OverSurgery2
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 21/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// MetaLayer interfaces with database connection to insert and select from the database
    /// </summary>
    public class MetaLayer
    {
        static private MetaLayer m_Instance = null;
        PersonFactory pf;
        private MetaLayer() {
        }

        static public MetaLayer Instance()
        {
            if (null == m_Instance)
            {
                m_Instance = new MetaLayer();
            }
            return m_Instance;
        }

        public List<Patient> GetPatients()
        {
            pf = PersonFactory.Instance();
            List<Patient> patients = new List<Patient>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient ORDER BY Surname;");
                Dictionary<string, object> values = null;
                //Read the data and store them in the list
                while (dr.Read())
                {
                    values = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "Gender", dr.GetInt16(3) },
                        { "DateOfBirth", dr.GetDateTime(4) },
                        { "PhoneNumber", dr.GetString(5) },
                        { "RegisteredDoctorID", dr.GetInt16(6) },
                        { "AddressID", dr.GetInt16(7) },
                    };
                    patients.Add(pf.CreatePatient(values));
                }
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return patients;
        }

        public Tuple<string, string, int?> GetLogin(string p_username)
        {
            #region Declaration
            string m_username, m_password;
            int? m_type;
            Tuple<string, string, int?> m_login;
            #endregion
            #region Initialisation
            m_username = null;
            m_password = null;
            m_type = null;
            m_login = new Tuple<string, string, int?>(null, null, null);
            #endregion
            #region Execution
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT Username, Password, Type FROM Staff WHERE Username = '" + p_username + "' LIMIT 1;");
                while (dr.Read())
                {
                    m_username = dr.GetString(0);
                    m_password = dr.GetString(1);
                    m_type = dr.GetInt32(2);
                }
                m_login = new Tuple<string, string, int?>(m_username, m_password, m_type);
                dr.Close();
                con.CloseConnection();
            }
            else
            {
                m_login = new Tuple<string, string, int?>(null, null, null);
            }
            #endregion
            #region Return
            return m_login;
            #endregion
        }

        public List<Medication> getMedication()
        {
            List<Medication> medication = new List<Medication>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT MED_ID, MED_Name, MED_PermLevel FROM medication;");

                while (dr.Read())
                {
                }
                dr.Close();
                con.CloseConnection();
            }
            return medication;
        }

        public string GetMedicalStaffNameByID(int p_id)
        {
            string firstname = null, lastname = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT forename, surname FROM staff WHERE exists(SELECT * FROM medicalstaff where medicalstaffid =" + p_id + " and staff.staffid = medicalstaff.staffid);");

                while (dr.Read())
                {
                    firstname = dr.GetString(0);
                    lastname = dr.GetString(1);
                }
                dr.Close();
                con.CloseConnection();
            }
            return firstname + " " + lastname;
        }

        public Patient GetPatientByID(int p_id)
        {
            Dictionary<string, object> id;
            id = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM PATIENT WHERE PatientID = '" + p_id + "';");

                while (dr.Read())
                {
                    id = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "Gender", dr.GetInt16(3) },
                        { "DateOfBirth", dr.GetDateTime(4) },
                        { "PhoneNumber", dr.GetString(5) },
                        { "RegisteredDoctorID", dr.GetInt16(6) },
                        { "AddressID", dr.GetInt16(7) },
                    };

                }
                dr.Close();
                con.CloseConnection();
            }
            return pf.CreatePatient(id);
        }

        public bool InsertNewPatient(Dictionary<string, object> p_PatientValues)
        {
            {
                DataConnection con = DBFactory.Instance();
                if (con.OpenConnection())
                {
                    try
                    {
                        con.Insert("INSERT INTO patient VALUES (NULL," + p_PatientValues["Forename"] + "," + p_PatientValues["Surname"] + "," + p_PatientValues["Gender"] + "," + p_PatientValues["DateOfBirth"] + "," + p_PatientValues["PhoneNumber"] + "," +
                            p_PatientValues["RegisteredDoctorID"] + p_PatientValues["AddressID"] + ");");
                        con.CloseConnection();
                        return true;

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw e;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Return an address by its ID.
        /// </summary>
        /// <param name="p_id">Use Address ID</param>
        /// <example>
        /// This example shows you how to use the <see cref="GetAddressByID(int)"/> method.
        /// <code>
        /// string address = ml.GetAddressByID(1);
        /// </code>
        /// </example>
        /// <returns>Returns an address string</returns>
        public string GetAddressByID(int p_id)
        {
            string houseName = null;
            int? houseNumber = null;
            string houseNumberStr = null;
            string address = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM ADDRESS WHERE AddressID = " + p_id + ";");

                while (dr.Read())
                {
                    string temp;
                    try
                    {
                        temp = dr.GetFieldValue<string>(1);
                    }
                    catch
                    {
                        temp = null;
                    }
                    if (temp == null)
                    {
                        houseName = "";
                        houseNumber = dr.GetFieldValue<int?>(2);
                    }
                    else
                    {
                        houseName = dr.GetString(1);
                        houseNumber = 0;
                    }
                    if (houseNumber == 0)
                    {
                        houseNumberStr = "";
                    }
                    else
                    {
                        houseNumberStr = Convert.ToString(houseNumber);
                    }
                    address = houseName + " " + houseNumberStr + " " + dr.GetString(3) + " " + dr.GetString(4);
                    Console.WriteLine(address);
                }
                dr.Close();
                con.CloseConnection();
            }
            return address;
        }

        public string GetStaffEmailByUserName(string p_username)
        {
            string email = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT email FROM Staff WHERE username = '" + p_username + "';");

                while (dr.Read())
                {
                    email = dr.GetString(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return email;
        }

        public Staff GetStaffByUserName(string p_username)
        {
            Dictionary<string, object> d;
            d = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Staff WHERE username = '" + p_username + "';");

                while (dr.Read())
                {
                    d = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "Email", dr.GetString(3) },
                        { "AddressID", dr.GetInt16(4) },
                        { "UserName", dr.GetString(5) },
                        { "Password", dr.GetString(6)},
                        { "Type", dr.GetInt16(7) },
                        { "Gender", 0 },
                        { "PhoneNumber", " " }

                    };
                }
                dr.Close();
                con.CloseConnection();
                int[] types = { 1, 2, 3 };
                if (types.Contains(Convert.ToInt16(d["Type"])))
                {
                    return GetMedicalStaffByStaffID(Convert.ToInt16(d["ID"]));
                }
                return pf.CreateStaff(d);
            }
            return pf.CreateStaff(d);
        }

        public Staff GetMedicalStaffByStaffID(int p_id)
        {
            Dictionary<string, object> d;
            d = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM medicalstaff INNER JOIN staff on medicalstaff.staffid = staff.staffid WHERE staff.staffid =" + p_id + ";");

                while (dr.Read())
                {
                    d = new Dictionary<string, object>
                    {
                        {"MedicalStaffID", dr.GetInt16(0) },
                        { "PracticeNumber", dr.GetString(1) },
                        { "ID", dr.GetInt16(3) },
                        { "Gender", dr.GetInt16(4) },
                        { "Forename", dr.GetString(6) },
                        { "Surname", dr.GetString(7) },
                        { "AddressID", dr.GetString(9) },
                        {"Email", dr.GetString(8) },
                        {"UserName", dr.GetString(10) },
                        { "Password", dr.GetString(11)},
                        {"Type", dr.GetInt16(12) },
                        {"PhoneNumber", " " }


                    };
                }
                dr.Close();
                con.CloseConnection();
            }
            return PersonFactory.Instance().CreateStaff(d);
        }

        public bool GetMedicalIfExists(int p_id)
        {
            Dictionary<string, object> d;
            d = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT COUNT(*) FROM medicalstaff INNER JOIN staff on medicalstaff.staffid = staff.staffid WHERE staff.staffid =" + p_id + ";");

                while (dr.Read())
                {
                    if (dr.GetInt16(0) == 0)
                    {
                        dr.Close();
                        con.CloseConnection();
                        return false;
                    }
                }
                dr.Close();
                con.CloseConnection();
                return true;
            }
            return false;

        }

        public int GetMedicalStaffIDByStaffID(int p_id)
        {
            int id = 0;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT medicalstaffid FROM medicalstaff WHERE exists(SELECT * FROM staff where staffid =" + p_id + " and staff.staffid = medicalstaff.staffid);");

                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return id;


        }

        public string GetResetRequestCode(Staff p_user)
        {
            string verificationcode = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT verificationcode FROM resetrequests WHERE username = '" + p_user.Username + "';");

                while (dr.Read())
                {
                    verificationcode = dr.GetString(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return verificationcode;
        }

        public bool NewResetRequest(string username, string verificationcode)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Insert("INSERT INTO resetrequests VALUES ('" + username + "','" + verificationcode + "');");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        public bool UpdateStaffPassword(Staff p_Staff, string p_newPassword)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Update("UPDATE Staff Set password ='" + p_newPassword + "' WHERE username ='" + p_Staff.Username + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        public bool DeleteResetRequest(string user)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Delete("DELETE FROM resetrequests WHERE username ='" + user + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the patients details from searching just their name
        /// </summary>
        /// <param name="p_forename"></param>
        /// <param name="p_surname"></param>
        /// <returns></returns>
        public Patient GetPatientByName(string p_forename, string p_surname)
        {
            DataConnection con = DBFactory.Instance();
            Dictionary<string, object> d = null;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient WHERE forename = '" + p_forename + "' AND surname = '" + p_surname + "';");
                while (dr.Read())
                {
                    d = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "Gender", dr.GetInt16(3) },
                        { "DateOfBirth", dr.GetDateTime(4) },
                        { "PhoneNumber", dr.GetString(5) },
                        { "RegisteredDoctorID", dr.GetInt16(6) },
                        { "AddressID", dr.GetInt16(7) },
                        //{ "Email", dr.GetString(8) }
                    };
                }
                dr.Close();
                con.CloseConnection();
            }
            return pf.CreatePatient(d);

        }

        /// <summary>
        /// Get appointment details from the database
        /// </summary>
        public Appointment GetAppointmentByPatientId(int patientid)
        {
            // Read appointment values into dictionary
            Dictionary<string, object> appValues;
            appValues = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                // Find appointment specific data
                DbDataReader dr1 = con.Select("SELECT * FROM Appointment WHERE PatientID = " + patientid + ";");
                while (dr1.Read())
                {
                    /* AppointmentID 
                     * AppointmentDate
                     * AppointmentTime
                     * AppointmentNote
                     * AppointmentAttended
                     * MedicalStaffID
                     * PatientID
                     */
                    appValues = new Dictionary<string, object>
                    {
                        { "AppID", dr1.GetInt16(0) },
                        { "Date", dr1.GetString(1) },
                        { "Time", dr1.GetString(2) },
                        { "Notes", dr1.GetString(3) },
                        { "Attend", dr1.GetBoolean(4) },
                        { "MedStaffID", dr1.GetInt16(5) },
                        { "PatientID", dr1.GetInt16(6) },
                    };

                }
                dr1.Close();
                con.CloseConnection();
            }
            return new Appointment(appValues);

        }

        /// <summary>
        /// Get appointment from the database using a given id for a specific appointment
        /// </summary>
        /// <param name="appointmentid"></param>
        /// <returns></returns>
        public Appointment GetAppointmentById(int appointmentid)
        {
            // Read appointment values into dictionary
            Dictionary<string, object> appValues;
            appValues = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                // Find appointment specific data
                DbDataReader dr1 = con.Select("SELECT * FROM Appointment WHERE appointmentID = " + appointmentid + ";");
                while (dr1.Read())
                {
                    /* AppointmentID 
                     * AppointmentDate
                     * AppointmentTime
                     * AppointmentNote
                     * AppointmentAttended
                     * MedicalStaffID
                     * PatientID
                     */
                    appValues = new Dictionary<string, object>
                    {
                        { "AppID", dr1.GetInt16(0) },
                        { "Date", dr1.GetString(1) },
                        { "Time", dr1.GetString(2) },
                        { "Notes", dr1.GetString(3) },
                        { "Attend", dr1.GetBoolean(4) },
                        { "MedStaffID", dr1.GetInt16(5) },
                        { "PatientID", dr1.GetInt16(6) },
                    };

                }
                dr1.Close();
                con.CloseConnection();
            }
            return new Appointment(appValues);
        }

        /// <summary>
        /// Update Appointment in the database to take new values
        /// </summary>
        /// <param name="app"></param>
        public void UpdateAppointment(Appointment app)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                Console.WriteLine(Convert.ToInt32(app.AppDate.ToString("yyyyMMdd")));
                con.Update("UPDATE Appointment Set appointmentDate = " + Convert.ToInt32(app.AppDate.ToString("yyyyMMdd")) + ", AppointmentTime = "
                    + Convert.ToInt16(app.AppTime.ToString("HHmmss")) + ", appointmentNote = '" + app.Notes + "', appointmentAttended = "
                    + Convert.ToInt16(app.AppAttend) + " WHERE appointmentID = " + app.AppointmentID + " LIMIT 1;");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Add new appointment to the database
        /// </summary>
        /// <param name="app"></param>
        public void AddAppointment(Appointment app)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                /* AppointmentID
                 * AppointmentDate
                 * AppointmentTime
                 * AppointmentNote
                 * AppointmentAttended
                 * MedicalStaffID
                 * PatientID
                 */

                Console.WriteLine(Convert.ToInt32(app.AppDate.ToString("yyyyMMdd")));
                con.Update("INSERT INTO Appointment VALUES (null, " + Convert.ToInt32(app.AppDate.ToString("yyyyMMdd")) + ", " +
                    Convert.ToInt32(app.AppTime.ToString("HHmmss")) + ", '" + app.Notes + "', " + Convert.ToInt16(app.AppAttend) + ", " + app.MedicalStaffID + ", " + app.PatientID + ");");
                con.CloseConnection();
            }
        }
        /// <summary>
        /// Finds the appointments for one medical staff member for a given day.
        /// </summary>
        /// <param name="p_staffID"></param>
        /// <returns></returns>
        public List<Appointment> GetStaffAppointments(int p_staffID)
        {
            List<Appointment> appointments = new List<Appointment>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE MedicalStaffID = " + p_staffID + " ORDER BY AppointmentTime, AppointmentDate;");
                Dictionary<string, object> values = null;
                //Read the data and store them in the list
                while (dr.Read())
                {
                    values = new Dictionary<string, object>
                    {
                        { "AppID", dr.GetInt16(0) },
                        { "Date", dr.GetFieldValue<object>(1) },
                        { "Time", dr.GetFieldValue<object>(2) },
                        { "Notes", dr.GetString(3) },
                        { "Attend", dr.GetBoolean(4) },
                        { "MedStaffID", dr.GetInt16(5) },
                        { "PatientID", dr.GetInt16(6) },
                    };
                    appointments.Add(new Appointment(values));
                };
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return appointments;
        }
        /// <summary>
        /// finds all perscriptions based on the patient id
        /// ast Updated : 16/11/17,
        /// By j
        /// </summary>
        /// <param name="p_patientID"></param>
        /// <returns></returns>
        public List<Prescription> GetPatientsPerscriptions(int p_patientID)
        {
            List<Prescription> prescriptions = new List<Prescription>();
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Prescription WHERE PatientID = " + p_patientID + " ORDER BY DateIssued;");
                Dictionary<string, object> values = null;
                while (dr.Read())
                {
                    values = new Dictionary<string, object>
                    {
                        {"PrescriptionID",dr.GetInt16(0) },
                        {"DateIssued", dr.GetFieldValue<object>(1)},
                        {"DateOfNextIssue", dr.GetFieldValue<object>(2) },
                        { "Ammount", dr.GetInt16(3) },
                        { "Extenable", dr.GetBoolean(4) },
                        { "MedicationID",dr.GetInt16(5) },
                        { "PatientID", dr.GetInt16(6) },
                        { "MedicalStaffID",dr.GetInt16(7) }
                    };
                    prescriptions.Add(new Prescription(values));
                }
            }
            return prescriptions;
        }

            public List<Prescription> GetPatientsMedicalHiatory(int p_patientID)
            {
                List<Prescription> medicalHistoy = new List<Prescription>();
                DataConnection con = DBFactory.Instance();
                if (con.OpenConnection())
                {
                    DbDataReader dr = con.Select("SELECT * FROM  WHERE PatientID = " + p_patientID + " ORDER BY DateIssued;");
                    Dictionary<string, object> values = null;
                    while (dr.Read())
                    {
                        values = new Dictionary<string, object>
                        {
                            {"MedicalHistoryID",dr.GetInt16(0) },
                            {"DateIssued", dr.GetFieldValue<object>(1)},
                            {"DateOfNextIssue", dr.GetFieldValue<object>(2) },
                            { "Ammount", dr.GetInt16(3) },
                            { "Extenable", dr.GetBoolean(4) },
                            { "MedicationID",dr.GetInt16(5) },
                            { "PatientID", dr.GetInt16(6) },
                            { "MedicalStaffID",dr.GetInt16(7) }
                        };
                        medicalHistoy.Add(new MedicalHistory(values));
                    }

                }
                return null;
            }

        public List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment ORDER BY AppointmentTime, AppointmentDate;");
                Dictionary<string, object> values = null;
                //Read the data and store them in the list
                while (dr.Read())
                {
                    values = new Dictionary<string, object>
                    {
                        { "AppID", dr.GetInt16(0) },
                        { "Date", dr.GetFieldValue<object>(1) },
                        { "Time", dr.GetFieldValue<object>(2) },
                        { "Notes", dr.GetString(3) },
                        { "Attend", dr.GetBoolean(4) },
                        { "MedStaffID", dr.GetInt16(5) },
                        { "PatientID", dr.GetInt16(6) },
                    };
                    appointments.Add(new Appointment(values));
                };
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return appointments;
        }

#region Rota
        /// <summary>
        /// Get all rota information from the database
        /// </summary>
        public Rota GetStaffRota()
        {
            // Read appointment values into dictionary
            Dictionary<string, object> rotaValues;
            rotaValues = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                // Find all rota data
                DbDataReader dr1 = con.Select("SELECT * FROM Rota;");
                while (dr1.Read())
                {
                    
                    rotaValues = new Dictionary<string, object>
                    {
                        { "RotaID", dr1.GetInt16(0) },
                        { "MedicalStaffID", dr1.GetString(1) },
                        { "StartDateTime", dr1.GetString(2) },
                        { "EndDateTime", dr1.GetString(3) },
                    };

                }
                dr1.Close();
                con.CloseConnection();
            }
            return new Rota(rotaValues);
        }

        /// <summary>
        /// Get all rota information for a specific staff member from the database
        /// </summary>
        /// <param name="p_rotaEntryID"></param>
        /// <returns></returns>
        public Rota GetStaffRotaByID(int p_rotaEntryID)
        {
            // Read appointment values into dictionary
            Dictionary<string, object> rotaValues;
            rotaValues = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                // Find all rota data
                DbDataReader dr1 = con.Select("SELECT * FROM Rota WHERE RotaID = " + p_rotaEntryID + ";");
                while (dr1.Read())
                {

                    rotaValues = new Dictionary<string, object>
                    {
                        { "RotaID", dr1.GetInt16(0) },
                        { "MedicalStaffID", dr1.GetString(1) },
                        { "StartDateTime", dr1.GetString(2) },
                        { "EndDateTime", dr1.GetString(3) },
                        
                    };

                }
                dr1.Close();
                con.CloseConnection();
            }
            return new Rota(rotaValues);
        }

        /// <summary>
        /// Add new rota entry to the database
        /// </summary>
        /// <param name="rota"></param>
        public void AddRota(Rota rota)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                Console.WriteLine(Convert.ToInt32(rota.StartTime.ToString("HHmmss")));
                con.Update("INSERT INTO Rota VALUES (null, " + rota.MedicalStaffID + ", " + Convert.ToInt32(rota.StartTime.ToString("HHmmss")) + ", " +
                    Convert.ToInt32(rota.EndTime.ToString("HHmmss")) + ");");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Update an existing rota
        /// </summary>
        /// <param name="rota"></param>
        public void UpdateRota(Rota rota)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                Console.WriteLine(Convert.ToInt32(rota.StartTime.ToString("HHmmss")));
                con.Update("UPDATE Rota Set StartDateTime = " + Convert.ToInt32(rota.StartTime.ToString("HHmmss")) + ", EndDateTime = "
                    + Convert.ToInt16(rota.EndTime.ToString("HHmmss")) + " LIMIT 1;");
                con.CloseConnection();
            }
        }
#endregion
    }
}

