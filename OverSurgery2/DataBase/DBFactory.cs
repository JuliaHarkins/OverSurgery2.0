using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace OverSurgery
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 21/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// Class to create connections to database
    /// </summary>
    public class DBFactory
    {
        Dictionary<string, string> m_properties;
        private static DataConnection m_Instance;
        private static string propfile = "properties.dat";
        private DBFactory()
        {
            m_properties = new Dictionary<string, string>();
        }
        public static DataConnection Instance()
        {
            if(m_Instance == null)
            {
                DBFactory factory = new DBFactory();
                m_Instance = factory.getConnection();
            }
            return m_Instance;
        }

        private DataConnection getConnection()
        {
            DataConnection connection = null;

            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("MySQL"))
                    connection = new DBConnect(m_properties);
                else
                {
                    // should throw unsupport exception here
                    throw new DBException("Not supported provider '" + provider + "'");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }
        private Dictionary<string, string> getProperties()
        {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", null);
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }

    class DBException : System.Exception
    {
        public DBException(string message) : base(message) { }
    }




    public interface DataConnection
    {
        bool OpenConnection();

        bool CloseConnection();

        void Insert(String query); 
        //Update statement
        void Update(String query);
        void Delete(String query);


        //Select statement
        DbDataReader Select(String query);
        /*
        //Count statement
        public int Count();
        public void Backup();
        public void Restore();
       
        */

        DataSet getDataSet(string sqlStatement);

    }
}
