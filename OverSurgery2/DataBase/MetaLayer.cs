using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace OverSurgery2
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 21/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// MetaLayer interfaces with database connection to insert and select from the database
    /// </summary>
    class MetaLayer
    {
        static private MetaLayer m_Instance = null;
        PersonFactory pf = PersonFactory.Instance();

        private MetaLayer() { }

        static public MetaLayer Instance()
        {
            if (null == m_Instance)
            {
                m_Instance = new MetaLayer();
            }
            return m_Instance;
        }

        public List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient;");
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
                };
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
                    medication.Add(new Medication
                    {
                        ID = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        PermissionLevel = dr.GetInt32(2)
                    });
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
                DbDataReader dr = con.Select("SELECT forename, surname FROM staff WHERE exists(SELECT * FROM medicalstaff where medicalstaffid ="
                    +p_id+" and staff.staffid = medicalstaff.staffid);");

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

        /// <summary>
        /// Return a Patient by their ID.
        /// </summary>
        /// <param name="p_id">Use Patient ID</param>
        /// <example>
        /// This example shows you how to use the <see cref="GetPatientByID(int)"/> method.
        /// <code>
        /// Patient p = ml.GetPatientByID(1);
        /// </code>
        /// </example>
        /// <returns>Returns a Patient</returns>
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

        public bool InsertNewPatient(Dictionary<string,object> p_PatientValues)
        {
            {
                DataConnection con = DBFactory.Instance();
                if (con.OpenConnection())
                {
                    try
                    {
                        con.Insert("INSERT INTO patient VALUES (NULL," + p_PatientValues["Forename"] + "," + p_PatientValues["Surname"] + "," + p_PatientValues["RegisteredDoctorID"] +
                            p_PatientValues["AddressID"] + "," + p_PatientValues["DateOfBirth"] + ");");
                        con.CloseConnection();
                        return true;
                    }
                    catch(Exception e)
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
            }
            return pf.CreateStaff(d);
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

        public void DeleteResetRequest(string user)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Delete("DELETE FROM resetrequests WHERE username ='" + user + "';");
                con.CloseConnection();
            }
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
                DbDataReader dr = con.Select("SELECT * FROM patient WHERE forename = '" + p_forename + "' AND surname = '" + p_surname + "' LIMIT 1;");
                while (dr.Read())
                {
                    d = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "RegisteredDoctorID", dr.GetInt16(3) },
                        { "AddressID", dr.GetInt16(4) },
                        { "DateOfBirth", dr.GetDateTime(5) }
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

            // Read patient values into dictionary
            Dictionary<string, object> patientValues;
            patientValues = null;
            if (con.OpenConnection())
            {
                // Find patient specific data
                DbDataReader dr2 = con.Select("SELECT * FROM PATIENT WHERE PatientID = '" + patientid + "';");
                while (dr2.Read())
                {
                    patientValues = new Dictionary<string, object>
                    {
                        { "PatientID", dr2.GetInt16(0) },
                        { "Forename", dr2.GetString(1) },
                        { "Surname", dr2.GetString(2) },
                        { "Gender", dr2.GetInt16(3) },
                        { "DateOfBirth", dr2.GetDateTime(4) },
                        { "PhoneNumber", dr2.GetString(5) },
                        { "RegisteredDoctorID", dr2.GetInt16(6) },
                        { "AddressID", dr2.GetInt16(7) },
                    };

                }
                dr2.Close();
                con.CloseConnection();
            }

            // Add together collected dictionaries, Discard unwanted fields and pass them as a new dictionary
            Dictionary<string, object> fullApp; 
            fullApp = new Dictionary<string, object>
            {
                { "AppID", (appValues["AppID"]) },
                { "Date", (appValues["Date"]) },
                { "Time", (appValues["Time"]) },
                { "Notes", (appValues["Notes"]) },
                { "Attend", (appValues["Attend"]) },
                { "MedStaffID", (appValues["MedStaffID"]) },
                { "PatientID", (patientValues["PatientID"]) },
                { "Forename", (patientValues["Forename"]) },
                { "Surname", (patientValues["Surname"]) },
                { "DateOfBirth", (patientValues["DateOfBirth"]) },
            };
            return new Appointment(fullApp);

        }
    }
}

