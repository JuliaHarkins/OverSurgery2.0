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
        //ME!
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


        public bool InsertNewPatient(Patient p_Patient)
        {
            {
                if (con.OpenConnection())
                {
                    try
                    {
                        con.Insert("INSERT INTO patient VALUES (NULL," + p_Patient.Forename + "," + p_Patient.Surname + "," + p_Patient.Gender + "," + p_Patient.DateOfBirth + "," + p_Patient.PhoneNumber + "," +
                            p_Patient.RegisteredDoctorID + p_Patient.AddressID + ");");
                        con.CloseConnection();
                        return true;

                    }
                    catch (Exception e)
                    {
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
        public Address GetAddressByID(int p_id)
        {
            Address a = null;
            string houseName = null;
            int? houseNumber = null;
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
                    a = new Address
                    {
                        HouseName = houseName,
                        HouseNumber = houseNumber,
                        StreetName = dr.GetString(3),
                        PostCode = dr.GetString(4)

                    };
                }
                dr.Close();
                con.CloseConnection();
            }
            return a;
        }

        public string GetStaffEmailByUserName(string p_username)
        {
            string email = null;
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
                        PhoneNumber = dr.GetString(3),
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
                return m;
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
        public List<Medication> getMedicationOnMedStaffID(uint? p_id)
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
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE MedicalStaffID = " + p_staffID + " ORDER BY AppointmentTime, AppointmentDate;");
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
                DbDataReader dr = con.Select("SELECT * FROM Prescription WHERE PatientID =  " + p_patientID +  " ORDER BY DateIssued;");
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
        }/// <summary>
        /// Counts the extentions for the doctor
        /// </summary>
        /// <param name="p_id">the doctors id</param>
        /// <returns></returns>
        public int DoctorExtentionCount(int p_id)
        {
            int i = 0;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT COUNT(MedicalStaffID) FROM Extension WHERE MedicalStaffID =  " + p_id + " ORDER BY DateOfExtension DESC;");
                while (dr.Read())
                {
                    i = dr.GetInt16(0);
                }
                dr.Close();
                con.CloseConnection();
            }

                    return i;
        }
        public List<Prescription> getExtentionRequests(int p_id)
        {
            List<Prescription> prescriptions = new List<Prescription>();
            Prescription p;
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT Prescription.PrescriptionID, Prescription.DateIssued, Prescription.Ammount, Prescription.PatientID FROM Prescription, Extension WHERE MedicalStaffID = " + p_id+ " AND Prescription.PrescriptionID = Extension.PrescriptionID;");
                while (dr.Read())
                {
                    p = new Prescription
                    {

                    };
                    prescriptions.Add(p);
                }
                dr.Close();
                con.CloseConnection();
            }

            return prescriptions;
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
                    con.Update("INSERT INTO Rota VALUES (null, " + rota.MedicalStaffID + ", " + Convert.ToInt32(rota.StartTime.ToString("HHmmss")) + ", " +
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
        Appointment a;
            List<Appointment> missedApp = new List<Appointment>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointment WHERE Attend = 0;");
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
                missedApp.Add(a);
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
            /* `StaffID` 
                * `Forename`
                * `Surname`
                * `Email` 
                * `AddressID` 
                * `Username` 
                * `Password`
                */
            if (con.OpenConnection())
            {

                con.Update("INSERT INTO Staff VALUES (null, " + staff.Forename + ", " + staff.Surname + ", " + staff.EmailAddress + ", " +
                    Convert.ToInt32(staff.AddressID) + ", " + staff.Username + ", " + staff.Password + ");");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Delete a staff member from the database
        /// Last Updated : 17/11/17,
        /// By R
        /// </summary>
        public bool DeleteStaff(string p_username)
        {
            if (con.OpenConnection())
            {
                con.Update("DELETE FROM Staff WHERE username ='" + p_username + "';");
                con.CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the full staff rota
        /// Last Updated : 21/11/17,
        /// By R
        /// </summary>
        /// <returns></returns>
        public List<Rota> GetStaffRota()
        {
            Rota r;
            List<Rota> rota = new List<Rota>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT RotaID, Forename, Surname, GROUP_CONCAT(DayName ORDER BY d.DayID ASC SEPARATOR ', ') AS 'Days Working' FROM Rota r, Staff s, DayOfWeek d WHERE r.DayID = d.DayID AND r.StaffID = s.StaffID GROUP BY S.StaffID ORDER BY s.StaffID;");
                while (dr.Read())
                {
                    r = new Rota
                    {
                        RotaEntryID = dr.GetInt32(0),
                        Forename = dr.GetString(1),
                        Surname = dr.GetString(2),
                        Days = dr.GetString(3)
                    };
                    rota.Add(r);
                }
                dr.Close();
                con.CloseConnection();
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
                con.Update("UPDATE Staff Set Forename = " + staff.Forename + ", Surname = "
                    + staff.Surname + ", Email = '" + staff.EmailAddress + ", Username = "
                    + staff.Username + ", Password = " + staff.Password + /*", Type = " 
                + staff.Type + */" WHERE StaffID = " + staff.StaffID + " LIMIT 1;");
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
        public void UpdateAddress(Address add)
        {
            if (con.OpenConnection())
            {
                con.Update("UPDATE Address Set HouseName = " + add.HouseName + ", HouseNumber = "
                    + add.HouseNumber + ", AddressLine1 = '" + add.StreetName + ", PostCode = "
                    + add.PostCode + " WHERE AddressID = " + /*add.AddressID +*/ " LIMIT 1;");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Add a new address to the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="add"></param>
        public void AddAddress(Address add)
        {
            if (con.OpenConnection())
            {
                con.Update("INSERT INTO Address VALUES (null, '" + add.HouseName + "', " + add.HouseNumber + 
                    ", '" + add.StreetName + "', '" + add.PostCode + "');");
                con.CloseConnection();
            }
        }

        /// <summary>
        /// Delete medication from the database
        /// Last Updated : 20/11/17,
        /// By R
        /// </summary>
        /// <param name="p_medName"></param>
        /// <returns></returns>
        public bool DeleteMedication(string p_medName)
        {
            if (con.OpenConnection())
            {
                con.Update("DELETE FROM Medication WHERE MedicationName ='" + p_medName + "';");
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
                DbDataReader dr = con.Select("SELECT MedicationID, PermissionLevel, MedicationName, Dosage FROM Medication WHERE MedicationName = " + p_medName + " LIMIT 1;");
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
    }
}