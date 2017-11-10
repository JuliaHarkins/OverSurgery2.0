﻿using System;
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
                DbDataReader dr = con.Select("SELECT PatientID, Forename, Surname, AddressID FROM patient;");
                Dictionary<string, object> values = null;
                //Read the data and store them in the list
                while (dr.Read())
                {
                    patients.Add(new Patient(values)
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
            Patient p;
            Dictionary<string, object> d;
            d = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM PATIENT WHERE PatientID = '" + p_id + "';");

                while (dr.Read())
                {
                    d = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Forename", dr.GetString(1) },
                        { "Surname", dr.GetString(2) },
                        { "RegisteredDoctorID", dr.GetInt16(3) },
                        { "AddressID", dr.GetInt16(4) },
                        //{ "DateOfBirth", dr.GetDateTime(5) }
                    };

                }
                dr.Close();
                con.CloseConnection();
            }
            return pf.CreatePatient(d);
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
            string address = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM ADDRESS WHERE AddressID = " + p_id + ";");

                while (dr.Read())
                {

                    address = dr.GetString(1) + " " + Convert.ToString(dr.GetInt16(2)) + " " + dr.GetString(3) + " " + dr.GetString(4);
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
                        { "Address", dr.GetInt16(4) },
                        { "UserName", dr.GetString(5) },
                        { "Password", dr.GetString(6)},
                        { "Type", dr.GetInt16(7) }
                       
                    };
                }
                dr.Close();
                con.CloseConnection();
            }
            return pf.CreateStaff(d);
        }

        public string GetResetRequestCode(string username)
        {
            string verificationcode = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT verificationcode FROM resetrequests WHERE username = '" + username + "';");

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

        public bool UpdateStaffPassword(string p_username, string p_newPassword)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Update("UPDATE Staff Set password ='" + p_newPassword + "' WHERE username ='" + p_username + "';");
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
            }
            return pf.CreatePatient(d);
        }

        /// <summary>
        /// Get appointment details from the database
        /// </summary>
        public Appointment GetAppointmentByPatientId(int id)
        {
            
            Dictionary<string, object> d;
            d = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                // Find appointment specific data
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE PatientID = " + id + ";");
                while (dr.Read())
                {
                    // AppointmentID 
                    // AppointmentDate
                    // AppointmentTime
                    // AppointmentNote
                    // AppointmentAttended
                    // MedicalStaffID
                    // PatientID
                    d = new Dictionary<string, object>
                    {
                        { "ID", dr.GetInt16(0) },
                        { "Date", dr.GetString(1) },
                        { "Time", dr.GetString(2) },
                        { "Notes", dr.GetString(3) },
                        { "Attend", dr.GetBoolean(4) },
                        { "MedStaffID", dr.GetInt16(5) },
                        { "PatientID", dr.GetInt16(6)},
                    };
                    //return new Appointment(d);
                }

            //    // Find patient specific data
            //    DbDataReader dr2 = con.Select("SELECT * FROM Patient WHERE PatientID = " + id + ";");
            //    while (dr.Read())
            //    {
            //        patientForename = dr.GetInt32(1);
            //        patientSurname = dr.GetInt32(2);
            //        patientDOB = dr.GetInt32(2);
                    
            //    }

            //    dr.Close();
            //    con.CloseConnection();
            //    a = new Appointment(appID, appTime, medicalStaffID, patientID, patientForename, patientSurname, appNote, patientDOB, appID, appAttend);
            }
            //return verificationcode;

        }
    }
}

