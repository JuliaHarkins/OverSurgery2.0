using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace OverSurgery
{
    class DB_TEST
    {
        public List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();

            DataConnection con = DBFactory.Instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    patients.Add(new Patient
                    {
                        ID = dr.GetInt32(0),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Address = dr.GetInt32(4)
                        //PhoneNumber = dr.GetString(5)
                    });
                }
                // Close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return patients;
        }

        public void PatientList()
        {
            List<Patient> patient = getPatients();
            foreach (Patient p in patient)
            {
                Console.WriteLine("{0} {1} {2}", p.ID, p.FirstName, p.LastName);
            }
            Console.WriteLine("Well...");
        }
    }
}
