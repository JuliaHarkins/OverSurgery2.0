using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

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
        DataConnection con = DBFactory.Instance();
        static private MetaLayer m_Instance = null;
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
            List<Patient> patients = new List<Patient>();
            Patient p = null;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient ORDER BY Surname;");
                //Read the data and store them in the list
                while (dr.Read())
                {
                    p = new Patient
                    {
                        ID = dr.GetInt16(0),
                        Forename = dr.GetString(1),
                        Surname = dr.GetString(2),
                        Gender = dr.GetInt16(3),
                        DateOfBirth = dr.GetDateTime(4),
                        PhoneNumber = dr.GetString(5),
                        RegisteredDoctorID = dr.GetInt16(6),
                        AddressID = Convert.ToUInt16(dr.GetInt16(7))
                    };
                    patients.Add(p);
                }
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return patients;
        }

        public int getDoctorWithLowestPatient()
        {
            int lowest = 0;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("select count(patientid),regestereddoctorid from patient p, medicalstaff m where p.regestereddoctorid = m.medicalstaffid group by m.medicalstaffid order by m.medicalstaffid asc Limit 1;");
                while (dr.Read())
                {
                    lowest = dr.GetInt16(1);
                }
                dr.Close();
                con.CloseConnection();
            }
            return lowest;
        }
        //ME!
        public Tuple<string, string, int?> GetLogin(string p_username)
        {
            #region Declaration
            string m_username, m_password;
            int? m_type;
            #endregion
            #region Initialisation
            m_username = null;
            m_password = null;
            m_type = null;
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
                dr.Close();
                con.CloseConnection();
            }
            #endregion
            #region Return
            return new Tuple<string, string, int?>(m_username, m_password, m_type); 
            #endregion
        }

        public List<Medication> getMedication()
        {
            List<Medication> medication = new List<Medication>();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public string GetMedicalStaffNameById(int p_id)
        {
            string firstname = null, lastname = null;
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

        /// <summary>
        /// Insert a new patient into the database by passing a patient object to the method
        /// </summary>
        /// <param name="p_patient">Patient object that you want inserted into the database.</param>
        /// <example>This shows you how to use the method<see cref="InsertNewPatient(Patient)"/>.</example>
        /// <returns>Returns true or false depending on whether the patient was inserted</returns>
        public bool InsertNewPatient(Patient p_patient)
        {
            //If connection to database can be opened, try to insert a patient to the database
            if (con.OpenConnection())
            {
                try
                {
                    con.Insert("INSERT INTO patient VALUES (NULL,'" + p_patient.Forename + "','" +
                                p_patient.Surname + "'," + p_patient.Gender + "," +
                                Convert.ToInt32(p_patient.DateOfBirth.ToString("yyyyMMdd")) + ",'" +
                                p_patient.PhoneNumber + "'," +
                                p_patient.RegisteredDoctorID + "," + p_patient.AddressID + ");");
                    con.CloseConnection();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// Get Address from Database by AddressID
        /// </summary>
        /// <param name="p_id">AddressID passed into method</param>
        /// <example>
        /// This is example shows you how to use the method <see cref="GetAddressById(int)"/>
        /// <c>Address a = GetAddressById(1);</c>
        /// </example>
        /// <returns>Returns Address object retrieved from database.</returns>
        public Address GetAddressById(int p_id)
        {
            Address a = null;
            string houseName = null;
            int? houseNumber = null;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Address WHERE AddressID = " + p_id + ";");
                while (dr.Read())
                {
                    houseName = dr.IsDBNull(1) ? null : dr.GetFieldValue<string>(1);
                    houseNumber = dr.IsDBNull(2) ? null : dr.GetFieldValue<int?>(2);
                    a = new Address
                    {
                        AddressID = dr.GetInt32(0),
                        HouseName = houseName,
                        HouseNumber = houseNumber,
                        StreetName = dr.GetString(3),
                        PostCode = dr.GetString(4)
                    };
                }
                dr.Close(); con.CloseConnection();
            }
            return a;
        }

        /// <summary>
        /// Gets staff email by username, used for password reset to send an email
        /// </summary>
        /// <example>This shows you how to to use the <see cref="GetStaffEmailByUserName(string)"/>
        /// <c>string emailAddress = GetStaffEmailByUserName("testUser");</c>
        /// </example>
        /// <param name="p_username"></param>
        /// <returns>Returns a string: email Address</returns>
        public string GetStaffEmailByUserName(string p_username)
        {
            // Set email to null
            string email = null;
            //If connection can be opened, grab email address for staff username(p_username)
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT email FROM Staff WHERE username = '" + p_username + "';");

                while (dr.Read())
                {
                    email = dr.GetString(0);
                }
                //Close the DbDataReader and the connection to database
                dr.Close();
                con.CloseConnection();
            }
            //Return the email address
            return email;
        }

        /// <summary>
        /// Gets the staff object by username passed to the method.
        /// </summary>
        /// <example></example>
        /// <param name="p_username">Staff username passed to method.</param>
        /// <returns>Returns a Staff object for the username that you have provided.</returns>
        public Staff GetStaffByUserName(string p_username)
        {
            Staff s = null;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Staff WHERE username = '" + p_username + "';");
                while (dr.Read())
                {
                    s = new Staff 
                    {
                        StaffID = dr.GetInt16(0),
                        Forename =dr.GetString(1),
                        Surname = dr.GetString(2),
                        EmailAddress = dr.GetString(3),
                        AddressID = Convert.ToUInt16(dr.GetInt16(4)),
                        Username = dr.GetString(5),
                        Password = dr.GetString(6),
                        Type = dr.GetInt16(7)

                    };
                }
                dr.Close();
                con.CloseConnection();
            }
            switch (s.Type)
            {
                case 1:
                case 2:
                case 3:
                    s = GetMedicalStaffByStaffID(s.StaffID, s.Type);
                    break;
            }
            return s;
        }
        public Staff GetMedicalStaffByStaffID(int p_id, int type)
        {
            MedicalStaff m = null;

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM medicalstaff m, staff s WHERE m.staffID =" + p_id + " AND m.staffID = s.staffID;");

                while (dr.Read())
                {
                    m = new MedicalStaff
                    {
                        MedicalStaffID = Convert.ToUInt16(dr.GetInt16(0)),
                        PracticeNumber = dr.GetString(1),
                        PhoneNumber = dr.GetString(2),
                        StaffID = dr.GetInt16(4),
                        Gender = Convert.ToUInt16(dr.GetInt16(5)),
                        Forename = dr.GetString(7),
                        Surname = dr.GetString(8),
                        AddressID = Convert.ToUInt16(dr.GetInt16(10)),
                        EmailAddress = dr.GetString(9),
                        Username = dr.GetString(11),
                        Password = dr.GetString(12),
                        Type = type
                        };

                }
                dr.Close();
                con.CloseConnection();
            }
            return m;
        }

        public bool GetMedicalIfExists(int p_id)
        {
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
            if (con.OpenConnection())
            {
                con.Insert("INSERT INTO resetrequests VALUES (null,'" + username + "','" + verificationcode + "');");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        public bool UpdateStaffPassword(Staff p_Staff, string p_newPassword)
        {
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
            if (con.OpenConnection())
            {
                con.Delete("DELETE FROM resetrequests WHERE username ='" + user + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get appointment details from the database
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>

        /// <summary>
        /// Get appointment from the database using a given id for a specific appointment
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        /// <param name="appointmentid"></param>
        /// <returns></returns>
        public Appointment GetAppointmentById(int appointmentid)
        {
            Appointment a = null;
            //Dictionary<string, object> appValues;
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
                    //appValues = new Dictionary<string, object>
                    //{
                    //    { "AppID", dr1.GetInt16(0) },
                    //    { "Date", dr1.GetString(1) },
                    //    { "Time", dr1.GetString(2) },
                    //    { "Notes", dr1.GetString(3) },
                    //    { "Attend", dr1.GetBoolean(4) },
                    //    { "MedStaffID", dr1.GetInt16(5) },
                    //    { "PatientID", dr1.GetInt16(6) },
                    //};

                    a = new Appointment
                    {
                        AppointmentID = dr1.GetInt16(0),
                        AppDate = DateTime.Parse(dr1.GetFieldValue<object>(1).ToString()),
                        AppTime = DateTime.Parse(dr1.GetFieldValue<object>(2).ToString()),
                        Notes = dr1.GetString(3),
                        AppAttend = dr1.GetBoolean(4),
                        MedicalStaffID = dr1.GetInt16(5),
                        PatientID = dr1.GetInt16(6)
                    };
                }
                dr1.Close();
                con.CloseConnection();
                return a;
            }
            return a;
        }

        /// <summary>
        /// Update Appointment in the database to take new values
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        /// <param name="app"></param>
        public void UpdateAppointment(Appointment app)
        {
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
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        /// <param name="app"></param>
        public void AddAppointment(Appointment app)
        {
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
        /// Uses the medicalHistory object to add a new medicalhistory to the databaes.
        /// Last Updated : 17/11/17,
        /// By j
        /// </summary>
        /// <param name="p_mh">the medical history</param>
        public void AddMedicalHistoryToTheDatabase(MedicalHistory p_mh)
        {
            if (con.OpenConnection())
            {
                con.Update("INSERT INTO MedicalHistory VALUES (null" + ", '" + p_mh.Notes + "', " + p_mh.Date.ToString("yyyyMMdd") + ", " + p_mh.PatientID + ");");
                con.CloseConnection();
            }
        }
        /// <summary>
        /// gets the medication avalible to the medicalstaff member using their staff id.
        /// Last Updated : 27/11/17,
        /// By j
        /// </summary>
        /// <param name="p_id">medicalStaffID</param>
        /// <returns></returns>
        public List<Medication> GetMedicationOnMedStaffID(uint? p_id)
        {
            int permissionLevel = 0;
            List<Medication> medication = new List<Medication>();
            Medication m;
            if (con.OpenConnection())
            {
                DbDataReader dr1 = con.Select("SELECT PermissionLevel FROM MedicalStaff WHERE MedicalStaffID =" + p_id + ";");
                while (dr1.Read())
                {
                    permissionLevel = dr1.GetInt32(0);
                }
                dr1.Close();

                DbDataReader dr2 = con.Select("SELECT MedicationID, PermissionLevel, MedicationName, Dosage FROM Medication WHERE PermissionLevel <= " +  permissionLevel + " ORDER BY MedicationName;");

                while (dr2.Read())
                {
                    m = new Medication();
                    m.ID = Convert.ToUInt16(dr2.GetInt16(0));
                    m.PermissionLevel = Convert.ToUInt16(dr2.GetInt16(1));
                    m.Name = dr2.GetString(2);
                    m.Dosage = dr2.GetString(3);

                    medication.Add(m);
                }
                dr2.Close();
                con.CloseConnection();
            }
        return medication;
        }
        /// <summary>
        /// Uses the perscription object to add a new perscription to the databaes.
        /// Last Updated : 15/11/17,
        /// By j
        /// </summary>
        /// <param name="p_p">the perscription</param>
        public void AddPrescriptionToTheDatabase(Prescription p_p)
            {
            if (con.OpenConnection())
                {
                    if (p_p.DateOfNextIssue == null)
                    {
                        con.Update("INSERT INTO Prescription VALUES (null, " + p_p.Date.ToString("yyyyMMdd") + ", null, " + p_p.Amount + ", " + p_p.Extendable +
                        ", " + p_p.MedicationID + ", " + p_p.PatientID + ", " + p_p.MedicalStaffID + ");");
                    }
                    else
                    {
                        con.Update("INSERT INTO Prescription VALUES (null, " + p_p.Date.ToString("yyyyMMdd") + ", " + p_p.DateOfNextIssue.Value.ToString("yyyyMMdd") + ", " + p_p.Amount + ", " + p_p.Extendable +
                        ", " + p_p.MedicationID + ", " + p_p.PatientID + ", " + p_p.MedicalStaffID + ");");
                        con.CloseConnection();
                    }
                }
        con.CloseConnection();
        }

        /// <summary>
        /// Finds the appointments for one medical staff member for a given day.
        /// Last Updated : 21/11/17,
        /// By j
        /// </summary>
        /// <param name="p_staffID"></param>
        /// <returns></returns>
        public List<Appointment> GetStaffAppointments(int p_staffID)
        {
            List<Appointment> appointments = new List<Appointment>();
            Appointment a;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE MedicalStaffID = " + p_staffID + " AND AppointmentDate= "+ DateTime.Now.ToString("yyyyMMdd") + " ORDER BY AppointmentTime;");
                //Read the data and store them in the list
                while (dr.Read())
                {

                    a = new Appointment
                    {
                        AppointmentID = dr.GetInt16(0),
                        AppDate = DateTime.Parse(dr.GetFieldValue<object>(1).ToString()),
                        AppTime = DateTime.Parse(dr.GetFieldValue<object>(2).ToString()),
                        Notes = dr.GetString(3),
                        AppAttend = dr.GetBoolean(4),
                        MedicalStaffID = dr.GetInt16(5),
                        PatientID = dr.GetInt16(6)
                    };
                    appointments.Add(a);
                }
                dr.Close();
                con.CloseConnection();
            }
            return appointments;
        }
        /// <summary>
        /// finds all prescriptions based on the patient id.
        /// Last Updated : 21/11/17,
        /// By j
        /// </summary>
        /// <param name="p_patientID">the id of the patient</param>
        /// <returns></returns>
        public List<Prescription> GetPatientsPrescriptions(int p_patientID)
        {
            List<Prescription> prescriptions = new List<Prescription>();
            Prescription p;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT PrescriptionID, DateIssued, DateOfNextIssue,Amount,Extendable,MedicationID,PatientID,MedicalStaffID FROM Prescription WHERE PatientID =  " + p_patientID +  " ORDER BY DateIssued;");
                DateTime? NextIssueDate;   
                while (dr.Read())
                {
                    try
                    {
                       NextIssueDate = dr.GetFieldValue<DateTime?>(2);
                    }
                    catch
                    {
                        NextIssueDate = null;
                    }
                    p = new Prescription
                    {
                        ID = dr.GetInt16(0) ,
                        Date = dr.GetDateTime(1),
                        DateOfNextIssue = NextIssueDate,
                        Amount = dr.GetInt16(3) ,
                        Extendable = dr.GetBoolean(4) ,
                        MedicationID = dr.GetInt16(5),
                        PatientID = dr.GetInt16(6),
                        MedicalStaffID = dr.GetInt16(7)
                    };
                    prescriptions.Add(p);
                }
                dr.Close();
                con.CloseConnection();
                return prescriptions;
            }
            return prescriptions;
        }
        /// <summary>
         /// Counts the extentions for the doctor
         /// Last Updated : 28/11/17,
         /// By j
         /// </summary>
         /// <param name="p_id">the doctors id</param>
         /// <returns></returns>
        public int DoctorExtentionCount(int p_id)
        {
            int i = 0;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT COUNT(ExtensionID) FROM Extension WHERE MedicalStaffID =  " + p_id + " AND Extended = 0;");
                while (dr.Read())
                {
                    i = dr.GetInt16(0);
                }
                dr.Close();
                con.CloseConnection();
            }

                    return i;
        }/// <summary>
         /// gets the list of extended prescriptions based off the medstaff id
         /// Last Updated : 21/11/17,
         /// By j
         /// </summary>
         /// <param name="p_id"></param>
         /// <returns></returns>
        public List<Prescription> GetExtentedPrescriptions(int p_id)
        {
            List<Prescription> prescriptions = new List<Prescription>();
            Prescription p;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT Prescription.PrescriptionID, Prescription.DateIssued, Prescription.Amount, Prescription.MedicationID, Prescription.PatientID FROM Prescription, Extension WHERE Extension.MedicalStaffID = " + p_id + " AND Prescription.PrescriptionID = Extension.PrescriptionID AND Extended = 0;");
                while (dr.Read())
                {
                    p = new Prescription
                    {
                        ID =dr.GetInt16(0),
                        Date = dr.GetDateTime(1),
                        Amount =dr.GetInt16(2),
                        MedicationID = dr.GetInt16(3),
                        PatientID = dr.GetInt16(4)
                    };
                    prescriptions.Add(p);
                }
            dr.Close();
            con.CloseConnection();
            }

            return prescriptions;
        }
        /// <summary>
        /// gets the list of extendions based off the medstaff id
        /// Last Updated : 21/11/17
        /// By j
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Extension> GetExtentionRequests(int p_id)
        {
            List<Extension> extensions = new List<Extension>();
            Extension e;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT ExtensionID, Extended, PrescriptionID, MedicalStaffID, Reason FROM Extension WHERE MedicalStaffID = " + p_id + " AND Extended = 0;");
                while (dr.Read())
                {
                    e = new Extension
                    {
                        ExtentionID = dr.GetInt32(0),
                        Extended = dr.GetInt32(1),
                        PrescriptionID = dr.GetInt32(2),
                        MedicalStaffID = dr.GetInt32(3),
                        Reason = dr.IsDBNull(4) ? null : dr.GetString(4)
                    };
                    extensions.Add(e);
                }
                dr.Close();
                con.CloseConnection();
            }

            return extensions;
        }
        /// <summary>
        /// Updates the state of an extention
        /// Last Updated : 30/11/17,
        /// By j
        /// </summary>
        /// <param name="p_extensionID">the id of the extension</param>
        /// <param name="p_newExtentionState"> the new state of the extension</param>
        public void UpdateExtention(int p_extensionID, int p_newExtentionState)
        {
            if (con.OpenConnection())
            {
                con.Update("UPDATE Extension SET Extended = "+ p_newExtentionState + ", DateOfExtension =" + DateTime.Now.ToString("yyyyMMdd") + " WHERE ExtensionID = " + p_extensionID + ";");
            }
            con.CloseConnection();
        }

        public void NewExtension(Extension p_extension)
        {
            if (con.OpenConnection())
            {
                con.Insert("INSERT INTO Extension VALUES (null,0,"+p_extension.PrescriptionID+","+p_extension.DateOfExtension.ToString("yyyyMMdd")+","+p_extension.MedicalStaffID+",'"+p_extension.Reason+"');");
            }
            con.CloseConnection();
        }
        /// <summary>
        /// retrieves the medical history of the patient for the id given.
        /// Last Updated : 16/11/17,
        /// By j
        /// </summary>
        /// <param name="p_patientID">the id of the patient that you want to check</param>
        /// <returns></returns>
        public List<MedicalHistory> GetPatientsMedicalHiatory(int p_patientID)
        {
            List<MedicalHistory> medicalHistoy = new List<MedicalHistory>();
        MedicalHistory mh;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM MedicalHistory WHERE PatientID = " + p_patientID + " ORDER BY DateOf;");
                while (dr.Read())
                {
                mh = new MedicalHistory
                {
                    ID = dr.GetInt16(0),
                    Notes = dr.GetString(1),
                    Date = dr.GetDateTime(2),
                    PatientID = dr.GetInt16(3)
                };
                    medicalHistoy.Add(mh);
                }
                dr.Close();
                con.CloseConnection();
            }
            return medicalHistoy;
        }
        /// <summary>
        /// finds the name of the medication based off the id
        /// Last Updated : 17/11/17,
        /// By j
        /// </summary>
        /// <param name="p_medicationID">the id of the medication</param>
        /// <returns></returns>
        public string GetMedicationName(int p_medicationID)
        {
            string med = "";
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT DISTINCT MedicationName FROM Medication  WHERE MedicationID =" + p_medicationID + ";");
                while (dr.Read())
                {
                    med = dr.GetString(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return med;
        }
        /// <summary>
        /// Finds The medical Staffs staffid form its medStaff id
        /// Last Updated : 17/11/17,
        /// By j
        /// </summary>
        /// <param name="p_staffID">the staff id</param>
        /// <returns></returns>
        public int GetStafIDFromMedStaffID(int p_staffID)
        {
            int staffid = 0;
            if (con.OpenConnection())
            {
                //gets the staff id

                DbDataReader dr = con.Select("SELECT DISTINCT StaffID FROM MedicalStaff  WHERE MedicalStaffID =" + p_staffID + ";");
                while (dr.Read())
                {
                    staffid = dr.GetInt16(0);
                }

                dr.Close();
                con.CloseConnection();
            }
            //returns the title and surname

            return staffid;
        }
        
        /// <summary>
        /// Get StaffName With Title from the staffid
        /// Last Updated : 17/11/17,
        /// By j
        /// </summary>
        /// <param name="staffid">the staffmembers id</param>
        /// <returns></returns>
        public string GetStaffNameAndTitle(int staffid)
        {
            string medStaffName = "";
            int medStaffType = 0;
            string title = "";
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT DISTINCT Forename,Surname, Type FROM Staff  WHERE StaffID =" + staffid + ";");
                while (dr.Read())
                {
                    medStaffName = dr.GetString(0) + " " + dr.GetString(1);
                    medStaffType = dr.GetInt16(2);
                }
                //sets the title of the Staffmember
                switch (medStaffType)
                {
                    case 1:
                        title = "Nurse";
                        break;
                    case 2:
                    case 3:
                        title = "Dr";
                        break;
                    case 4:
                        title = "Receptionist";
                        break;
                    case 5:
                        title = "Manager";
                        break;

                }
                dr.Close();
                con.CloseConnection();
            }
            return title + " " + medStaffName;
        }

        public List<Appointment> GetAppointments()
        {
        Appointment a;
            List<Appointment> appointments = new List<Appointment>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment ORDER BY AppointmentTime, AppointmentDate;");
                //Read the data and store them in the list
                while (dr.Read())
                {
                a = new Appointment
                {
                    AppointmentID = dr.GetInt16(0),
                    AppDate = DateTime.Parse(dr.GetFieldValue<object>(1).ToString()),
                    AppTime = DateTime.Parse(dr.GetFieldValue<object>(2).ToString()),
                    Notes = dr.GetString(3),
                    AppAttend = dr.GetBoolean(4),
                    MedicalStaffID = dr.GetInt16(5),
                    PatientID = dr.GetInt16(6)
                };
                appointments.Add(a);
                };
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
                return appointments;
            }
            return appointments;
        }

        /// <summary>
        /// Get all rota information for a specific staff member from the database
        /// Last Updated : 21/11/17
        /// By R
        /// </summary>
        /// <param name="p_rotaEntryID"></param>
        /// <returns></returns>
        public List<Rota> GetStaffRotaByID(Rota p_rota)
        {
            // Read appointment values into list
            Rota r;
            List<Rota> rotaValues = new List<Rota>();
            StringBuilder dat = new StringBuilder();
            if (con.OpenConnection())
            {
                // Find all rota data
                DbDataReader dr = con.Select("SELECT * FROM Rota WHERE RotaID = " + p_rota.RotaEntryID + ";");
                while (dr.Read())
                {

                    while (dr.Read())
                    {
                        r = new Rota
                        {
                            RotaEntryID = dr.GetInt32(0),
                            Forename = dr.GetString(1),
                            Surname = dr.GetString(2),
                            Days = dr.GetString(3)
                        };
                        rotaValues.Add(r);
                    }

                }
                dr.Close();
                con.CloseConnection();
            }
            return rotaValues;
        }

        /// <summary>
        /// Add new rota entry to the database
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        /// <param name="rota"></param>
        public void AddRota(Rota rota)
            {
                if (con.OpenConnection())
                {
                    Console.WriteLine(Convert.ToInt32(rota.StartTime.ToString("HHmmss")));
                    con.Update("INSERT INTO Rota VALUES (null, " + rota.StaffID + ", " + Convert.ToInt32(rota.StartTime.ToString("HHmmss")) + ", " +
                        Convert.ToInt32(rota.EndTime.ToString("HHmmss")) + ");");
                    con.CloseConnection();
                }
            }

        /// <summary>
        /// Update an existing rota
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        /// <param name="rota"></param>
        public void UpdateRota(Rota rota)
        {
            if (con.OpenConnection())
            {
                Console.WriteLine(Convert.ToInt32(rota.StartTime.ToString("HHmmss")));
                con.Update("UPDATE Rota Set StartDateTime = " + Convert.ToInt32(rota.StartTime.ToString("HHmmss")) + ", EndDateTime = "
                    + Convert.ToInt16(rota.EndTime.ToString("HHmmss")) + " LIMIT 1;");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Get appointments that have been missed from the database
        /// Last Updated : 15/11/17,
        /// By R
        /// </summary>
        public List<Appointment> GetMissedAppointments()
        {
            Appointment app;
            List<Appointment> missedApp = new List<Appointment>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE Attend = 0;");
                //Read the data and store them in the list
                while (dr.Read())
                {
                    app = new Appointment
                    {
                        AppointmentID = dr.GetInt16(0),
                        AppDate = DateTime.Parse(dr.GetFieldValue<object>(1).ToString()),
                        AppTime = DateTime.Parse(dr.GetFieldValue<object>(2).ToString()),
                        Notes = dr.GetString(3),
                        AppAttend = dr.GetBoolean(4),
                        MedicalStaffID = dr.GetInt16(5),
                        PatientID = dr.GetInt16(6)
                    };
                    missedApp.Add(app);
                };
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return missedApp;
        }

        /// <summary>
        /// Add a new staff member to the database
        /// </summary>
        public void AddStaff(Staff staff)
        {
            if (con.OpenConnection())
            {

                con.Insert("INSERT INTO Staff VALUES (null, '" + staff.Forename + "', '" + staff.Surname + "', '" + staff.EmailAddress + "', '" +
                    Convert.ToInt32(staff.AddressID) + "', '" + staff.Username + "', '" + staff.Password + "'," + staff.Type + ");");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// add a medical staff member from the database
        /// Last Updated : 17/11/17,
        /// By R
        /// </summary>
        public void AddMedicalStaff(MedicalStaff m)
        {
            if (con.OpenConnection())
            {
                int staffid = 0;
                int permissionLevel = 0;
                con.Insert("INSERT INTO Staff VALUES (null, '" + m.Forename + "', '" + m.Surname + "', '" + m.EmailAddress + "', '" +
                    Convert.ToInt32(m.AddressID) + "', '" + m.Username + "', '" + m.Password + "'," + m.Type + ");");
                DbDataReader dr = con.Select("Select staffid from staff where username ='" + m.Username + "';");
                while (dr.Read())
                {
                    staffid = dr.GetInt32(0);
                }
                if(m.Type == 1)
                {
                    permissionLevel = 1;
                }
                else if(m.Type == 2)
                {
                    permissionLevel = 2;
                }
                else if(m.Type == 3)
                {
                    permissionLevel = 3;
                }
                dr.Close();
                con.Insert("INSERT INTO MedicalStaff VALUES (null, '" + m.PracticeNumber + "','" + m.PhoneNumber + "','" +permissionLevel + "'," + staffid + "," + m.Gender + ");");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// update a staff member in the database
        /// Last Updated : 17/11/17,
        /// By R
        /// </summary>
        public void UpdateMedicalStaff(MedicalStaff m)
        {
            if (con.OpenConnection())
            {
                int permissionLevel = 0;
                con.Insert("UPDATE Staff SET forename='"  +m.Forename + "', surname='" + m.Surname + "', emailaddress='" + m.EmailAddress + "', addressid='" +
                    Convert.ToInt32(m.AddressID) + "', username='" + m.Username + "', type='" + m.Type + "WHERE staffid="+m.StaffID+";");
                if (m.Type == 1)
                {
                    permissionLevel = 1;
                }
                else if (m.Type == 2)
                {
                    permissionLevel = 2;
                }
                else if (m.Type == 3)
                {
                    permissionLevel = 3;
                }
                con.Insert("UPDATE MedicalStaff SET practicenumber='" + m.PracticeNumber + "',phonenumber='" + m.PhoneNumber + "',permissonlevel='" + permissionLevel + ",gender=" + m.Gender + "WHERE medicalstaffid="+m.MedicalStaffID+";");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Delete a staff member from the database
        /// Last Updated : 17/11/17,
        /// By R
        /// </summary>
        public void DeleteStaff(Staff p_staff)
        {
            // Delete medical staff entry
            int medStaffID = 0;
            if (p_staff.Type == 1 || p_staff.Type == 2 || p_staff.Type == 3)
            {
                if (con.OpenConnection())
                {
                    DbDataReader dr = con.Select("SELECT MedicalStaffID FROM MedicalStaff WHERE MedicalStaff.StaffID =" + p_staff.StaffID + ";");
                    while (dr.Read())
                    {
                        medStaffID = dr.GetInt32(0);
                    }
                    dr.Close();
                    con.Delete("DELETE FROM MedicalStaff WHERE MedicalStaffID =" + medStaffID + ";");
                    con.Delete("DELETE FROM Staff WHERE StaffID =" + p_staff.StaffID + ";");
                    con.CloseConnection();
                }
            }
            else
            {
                if (con.OpenConnection())
                {
                    con.Update("DELETE FROM Staff WHERE StaffID ='" + p_staff.StaffID+ "';");
                    con.CloseConnection();
                }

            }
            // Delete normal staff entry
            
        }

        /// <summary>
        /// Get the full staff rota
        /// Last Updated : 21/11/17,
        /// By E
        /// </summary>
        /// <returns></returns>
        public List<Rota> GetStaffRota()
        {
            Rota r;
            List<Rota> rota = new List<Rota>();
            List<int> r_staffID = new List<int>();
            List<int> s_staffID = new List<int>();
            List<string> s_forename = new List<string>();
            List<string> s_surname = new List<string>();
            List<string> days = new List<string>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT StaffID, GROUP_CONCAT(DayName ORDER BY d.DayID ASC SEPARATOR ', ') AS 'Days Working' FROM Rota r, DayOfWeek d WHERE r.DayID = d.DayID GROUP BY StaffID ORDER BY StaffID;");
                while (dr.Read())
                {
                    r_staffID.Add(dr.GetInt32(0));
                    days.Add(dr.GetString(1));
                }
                dr.Close();
                con.CloseConnection();
            }
            if (con.OpenConnection())
            {
                DbDataReader inner_dr = con.Select("Select StaffID, Forename, Surname FROM Staff");
                while (inner_dr.Read())
                {
                    s_staffID.Add(inner_dr.GetInt32(0));
                    s_forename.Add(inner_dr.GetString(1));
                    s_surname.Add(inner_dr.GetString(2));
                }
                inner_dr.Close();
                con.CloseConnection();
            }
            if (r_staffID.Count == 0)
            {
                for (int i = 0; i < s_staffID.Count; i++)
                {
                    r = new Rota
                    {
                        StaffID = s_staffID.ElementAtOrDefault(i),
                        Forename = s_forename.ElementAtOrDefault(i),
                        Surname = s_surname.ElementAtOrDefault(i),
                        Days = "Default"
                    };
                    rota.Add(r);
                }
            }
            else
            {
                for (int i = 0, j = 0; j < r_staffID.Count; i++)
                {
                    if (s_staffID.ElementAtOrDefault(i) == r_staffID.ElementAtOrDefault(j))
                    {
                        for (int k = 0; k < rota.Count; k++)
                        {
                            if (rota.ElementAtOrDefault(k).StaffID == s_staffID.ElementAtOrDefault(i))
                            {
                                rota.RemoveAt(k);
                            }
                        }
                        r = new Rota
                        {
                            StaffID = s_staffID.ElementAtOrDefault(i),
                            Forename = s_forename.ElementAtOrDefault(i),
                            Surname = s_surname.ElementAtOrDefault(i),
                            Days = days.ElementAtOrDefault(j)
                        };
                        rota.Add(r);
                    }
                    else
                    {
                        if (s_staffID.Count > rota.Count)
                        {
                            bool flg = true;
                            for (int k = 0; k < rota.Count; k++)
                            {
                                if (rota.ElementAtOrDefault(k).StaffID == s_staffID.ElementAtOrDefault(i))
                                {
                                    flg = false;
                                }
                            }
                            if (flg)
                            {
                                r = new Rota
                                {
                                    StaffID = s_staffID.ElementAtOrDefault(i),
                                    Forename = s_forename.ElementAtOrDefault(i),
                                    Surname = s_surname.ElementAtOrDefault(i),
                                    Days = "Default"
                                };
                                rota.Add(r);
                            }
                        }
                    }
                    if (i == s_staffID.Count)
                    {
                        i = 0;
                        j++;
                    }
                }
            }
            return rota;
        }

        /// <summary>
        /// Update a staff members details
        /// Last Updated : 17/11/17,
        /// By R
        /// </summary>
        /// <param name="staff"></param>
        public void UpdateStaffMember(Staff staff)
        {
            if (con.OpenConnection())
            {
                con.Update("UPDATE Staff Set Forename = '" + staff.Forename + "', Surname = '"
                    + staff.Surname + "', Email = '" + staff.EmailAddress + "', Username = '"
                    + staff.Username + "', Type = "
                + staff.Type + " WHERE StaffID = " + staff.StaffID + ";");
                con.CloseConnection();
            }
        }

        public void UpdatePatient(Patient p)
        {
            if (con.OpenConnection())
            {
                con.Update("UPDATE Patient Set Forename = '" + p.Forename + "', Surname = '"
                           + p.Surname + "', Gender ='" + p.Gender + "', DateOfBirth=" +
                           Convert.ToInt32(p.DateOfBirth.ToString("yyyyMMdd")) + ", PhoneNumber='" + p.PhoneNumber +
                           "' WHERE PatientID =" + p.ID + ";");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Delete an address from the database using the addressID
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_addressID"></param>
        /// <returns></returns>
        public bool DeleteAddress(int p_addressID)
        {
            if (con.OpenConnection())
            {
                con.Update("DELETE FROM Address WHERE AddressID ='" + p_addressID + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update an address using the addressID
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="add"></param>
        public void UpdateAddress(Address add, int id)
        {
            int addid = id;
            if (con.OpenConnection())
            {
                con.Update("UPDATE Address Set HouseName = '" + add.HouseName + "', HouseNumber = '"
                    + add.HouseNumber + "', AddressLine1 = '" + add.StreetName + "', PostCode = '"
                    + add.PostCode + "' WHERE AddressID = "+id+";");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Add a new address to the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="add"></param>
        public int AddAddress(Address add, string p_column, string p_passedData)
        {
            List<int> addid = new List<int>();
            bool flg = true;
            int addressIDReturn = 0;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT addressid FROM address where housename ='" + add.HouseName + "' and housenumber='" + add.HouseNumber + 
                    "' and addressLine1='" + add.StreetName + "' and postcode='" + add.PostCode + "';");
                while (dr.Read())
                {
                    addid.Add(dr.GetInt32(0));
                }
                dr.Close();
                con.CloseConnection();
                for (int i = 0; i < addid.Count; i++)
                {
                    flg = false;
                }
                if (flg)
                {
                    addid.Clear();
                    if (con.OpenConnection())
                    {
                        con.Insert($"INSERT INTO Address{p_column} VALUES ({p_passedData});");
                        con.CloseConnection();
                    }
                    if (con.OpenConnection())
                    {
                        DbDataReader dr1 = con.Select("SELECT addressid FROM address where housename ='" + add.HouseName + "' and housenumber='" + add.HouseNumber +
                        "' and addressLine1='" + add.StreetName + "' and postcode='" + add.PostCode + "';");
                        while (dr1.Read())
                        {
                            addid.Add(dr1.GetInt32(0));
                        }
                        dr1.Close();
                        con.CloseConnection();
                    }
                }
                addressIDReturn = addid.ElementAtOrDefault(0);
            }
            return addressIDReturn;
        }

        /// <summary>
        /// Delete medication from the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_medID"></param>
        /// <returns></returns>
        public bool DeleteMedication(uint? p_medID)
        {
            if (con.OpenConnection())
            {
                con.Update("DELETE FROM Medication WHERE MedicationID ='" + p_medID + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get a medication from a name
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_medName"></param>
        /// <returns></returns>
        public List<Medication> GetMedicationByName(string p_medName)
        {
            Medication m;
            List<Medication> medList = new List<Medication>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT MedicationID, PermissionLevel, MedicationName, Dosage FROM Medication WHERE MedicationName = '" + p_medName + "';");
                while (dr.Read())
                {
                    m = new Medication
                    {
                        ID = Convert.ToUInt32(dr.GetInt32(0)),
                        PermissionLevel = Convert.ToUInt32(dr.GetString(1)),
                        Name = dr.GetString(2),
                        Dosage = dr.GetString(3)
                    };
                    medList.Add(m);
                }
                dr.Close();
                con.CloseConnection();
            }
            return medList;
        }

        /// <summary>
        /// Add a new medication to the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_med"></param>
        public void AddMedication(Medication p_med)
        {
            if (con.OpenConnection())
            {
                con.Insert("INSERT INTO Medication VALUES (null, '" + p_med.PermissionLevel + "', '" + p_med.Name + "', '" + p_med.Dosage + "');");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Update an existing medication in the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_med"></param>
        public void UpdateMedication(Medication p_med)
        {
            if (con.OpenConnection())
            {
                con.Update("UPDATE Medication Set PermissionLevel = '" + p_med.PermissionLevel + "', MedicationName = '"
                    + p_med.Name + "', Dosage = '" + p_med.Dosage + "' WHERE MedicationID = " + p_med.ID + ";");
                con.CloseConnection();
            }
        }

        public bool InsertIntoRota(int dayID, int staffID)
        {
            bool flg = false;
            if (con.OpenConnection())
            {
                con.Insert($"INSERT INTO Rota Values (null, {dayID}, {staffID});");
                flg = true;
                con.CloseConnection();
            }
            return flg;
        }

        public bool UpdateRota(int dayID, int staffID)
        {
            bool flg = false;
            if (con.OpenConnection())
            {
                con.Update($"DELETE FROM Rota WHERE DayID = {dayID} AND StaffID = {staffID}");
                flg = true;
                con.CloseConnection();
            }
            return flg;
        }

        public Tuple<List<int>, List<string>, List<string>, List<string>> SearchRota(string searchParam)
        {
            List<int> staffID = new List<int>();
            List<string> forename = new List<string>();
            List<string> surname = new List<string>();
            List<string> days = new List<string>();
            if (con.OpenConnection())
            {
                DbDataReader dr =
                    con.Select(
                        $"SELECT r.StaffID, Forename, Surname, GROUP_CONCAT(DayName ORDER BY d.DayID ASC) FROM DayOfWeek d, Rota r, Staff s WHERE {searchParam} AND d.DayID = r.DayID AND r.StaffID = s.StaffID GROUP BY r.StaffID ORDER BY s.StaffID;");
                while (dr.Read())
                {
                    staffID.Add(dr.GetInt32(0));
                    forename.Add(dr.GetString(1));
                    surname.Add(dr.GetString(2));
                    days.Add(dr.GetString(3));
                }
                dr.Close();
                con.CloseConnection();
            }
            return new Tuple<List<int>, List<string>, List<string>, List<string>>(staffID, forename, surname, days);
        }

        public Tuple<List<string>, List<string>, List<string>> SelectMedicalStaff_WithDateAddOn(string tables, string searchParam)
        {
            List<string> forename = new List<string>();
            List<string> surname = new List<string>();
            List<string> gender = new List<string>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select(
                    $"SELECT Forename, Surname, Gender FROM MedicalStaff ms, {tables} WHERE {searchParam} GROUP BY r.StaffID ORDER BY Surname, Forename;");
                while (dr.Read())
                {
                    forename.Add(dr.GetString(0));
                    surname.Add(dr.GetString(1));
                    if (dr.GetInt32(2) == 1)
                    {
                        gender.Add("M");
                    }
                    else
                    {
                        gender.Add("F");
                    }
                }
                dr.Close();
                con.CloseConnection();
            }
            return new Tuple<List<string>, List<string>, List<string>>(forename, surname, gender);
        }

        public List<int> SelectPatient(string searchParam)
        {
            List<int> patientID = new List<int>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT PatientID FROM Patient WHERE {searchParam}");
                while (dr.Read())
                {
                    patientID.Add(dr.GetInt32(0));
                }
                dr.Close();
                con.CloseConnection();
            }
            return patientID;
        }

        public Tuple<List<int>, List<string>, List<string>, List<string>, List<int>, List<string>, List<string>> SelectPatientAddress(string searchParam)
        {
            List<int> patientID = new List<int>();
            List<string> forename = new List<string>();
            List<string> surname = new List<string>();
            List<string> houseName = new List<string>();
            List<int> houseNumber = new List<int>();
            List<string> addressLine = new List<string>();
            List<string> postCode = new List<string>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT PatientID, Forename, Surname, HouseName, HouseNumber, AddressLine1, PostCode FROM Patient p, Address a WHERE {searchParam} AND p.AddressID = a.AddressID");
                while (dr.Read())
                {
                    patientID.Add(dr.GetInt32(0));
                    forename.Add(dr.GetString(1));
                    surname.Add(dr.GetString(2));
                    houseName.Add(dr.IsDBNull(3) ? "[#UDEF]" : dr.GetString(3));
                    houseNumber.Add(dr.IsDBNull(4) ? 0 : dr.GetInt32(4));
                    addressLine.Add(dr.GetString(5));
                    postCode.Add(dr.GetString(6));
                }
                dr.Close();
                con.CloseConnection();
            }
            return new Tuple<List<int>, List<string>, List<string>, List<string>, List<int>, List<string>, List<string>>(patientID, forename, surname,houseName, houseNumber, addressLine, postCode);
        }

        public List<int> GetMedicalStaffID(string searchParam)
        {
            List<int> medicalStaffID = new List<int>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT MedicalStaffID FROM MedicalStaff{searchParam}");
                while (dr.Read())
                {
                    medicalStaffID.Add(dr.GetInt32(0));
                }
                dr.Close();
                con.CloseConnection();
            }
            return medicalStaffID;
        }

        public List<int> SelectCurrentAppointments(string data, string searchParam)
        {
            List<int> time = new List<int>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT {data} FROM Appointment WHERE {searchParam}");
                while (dr.Read())
                {
                    time.Add(dr.GetInt32(0));
                }
                dr.Close();
                con.CloseConnection();
            }
            return new List<int>(time);
        }

        public int AddAppointment(int appointmentDate, int appointmentTime, string appointmentNotes, int medicalStaffID, int patientID)
        {
            int flg = 2;
            if (con.OpenConnection())
            {
                con.Insert($"INSERT INTO Appointment Values (null, {appointmentDate}, {appointmentTime}, '{appointmentNotes}', 0, {medicalStaffID}, {patientID});");
                flg = 3;
                con.CloseConnection();
            }
            return flg;
        }

        public string ReturnMedicalStaffName(int medicalStaffID)
        {
            string medicalStaffName = "";
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT Forename, Surname FROM MedicalStaff ms, Staff s WHERE MedicalStaffID = {medicalStaffID} AND ms.StaffID = s.StaffID LIMIT 1");
                while (dr.Read())
                {
                    medicalStaffName = dr.GetString(0) + " " + dr.GetString(1);
                }
                dr.Close();
                con.CloseConnection();
            }
            return medicalStaffName;
        }

        public int AppointmentCheck(string checkParam)
        {
            int flg = 1;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select($"SELECT AppointmentID FROM Appointment WHERE {checkParam}");
                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        flg = 0;
                    }
                }
                dr.Close();
                con.CloseConnection();
            }
            return flg;
        }

        public int GetRotaCount()
        {
            int count = 0;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT DISTINCT COUNT(MedicalStaffID) FROM Rota");
                while (dr.Read())
                {
                    count = dr.GetInt32(0);
                }
                dr.Close();
                con.CloseConnection();
            }
            return count;
        }
    }
}