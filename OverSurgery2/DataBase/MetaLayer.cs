﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace OverSurgery
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

                //Read the data and store them in the list
                while (dr.Read())
                {
                    patients.Add(new Patient
                    {
                        ID = dr.GetInt32(0),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Address = dr.GetInt32(3)
                    });
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
        public Patient getPatientByID(int id)
        {
            int Id = 0;
            string FirstN = null;
            string LastN = null;
            int Addr = 0;

            Patient p;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM PATIENT WHERE PatientID = '" + id + "';");

                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    FirstN = dr.GetString(1);
                    LastN = dr.GetString(2);
                    Addr = dr.GetInt16(4);
                }
            }
            p = new Patient { ID = Id, FirstName = FirstN, LastName = LastN, Address = Addr };
            return p;

        }
        public string getAddressByID(int id)
        {
            string address = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM ADDRESS WHERE AddressID = '" + id + "';");

                while (dr.Read())
                {

                    address = dr.GetString(1) + " " + Convert.ToString(dr.GetInt16(2)) + " " + dr.GetString(3) + " " + dr.GetString(4);
                }
                dr.Close();
                con.CloseConnection();
            }
            return address;
        }

        public string GetStaffEmailByUserName(string username)
        {
            string email = null;
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT email FROM Staff WHERE username = '" + username + "';");

                while (dr.Read())
                {
                    email = dr.GetString(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return email;
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
        public void NewResetRequest(string username, string verificationcode)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {

                con.Insert("INSERT INTO resetrequests VALUES ('" + username + "','" + verificationcode + "');");
                con.CloseConnection();
            }
        }
        public bool UpdateStaffPassword(string user, string newPassword)
        {
            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                con.Update("UPDATE Staff Set password ='" + newPassword + "' WHERE username ='" + user + "';");
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
    }
}

