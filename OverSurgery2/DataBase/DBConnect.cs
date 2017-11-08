using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace OverSurgery
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 21/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// Class to handle connection to database
    /// </summary>
    public class DBConnect : DataConnection
    {
        private Dictionary<string, string> m_properties;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        public DBConnect(Dictionary<string,string> properties)
        {
            m_properties = properties;
            Initialize();
        }
        // Initialize properties for database connection
        private void Initialize()
        {
            server = m_properties["Server"];
            database = m_properties["Database"];
            uid = m_properties["User"];
            password = m_properties["Password"];
            SetConnection();
        }

        private void SetConnection()
        {
            string connectionString;
            connectionString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";" + "password=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator\n" + ex.Message);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again\n" + ex.Message);
                        break;
                    default:
                        MessageBox.Show("Unable to connect to database exception:\n" + ex.Message);
                        break;
                }
                return false;
            }
            return true;
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public DbDataReader Select(String query)
        {
            DbDataReader dr = null;

            if (null != connection)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
            }
            return dr;
        }

        public void Insert(String query)
        {
            DbDataReader dr = null;

            if (null != connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                dr = cmd.ExecuteReader();
                dr.Close();
            }
        }

        public void Update(String query)
        {
            DbDataReader dr = null;
            if(null != connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                dr = cmd.ExecuteReader();
                dr.Close();
            }
        }

        public void Delete(String query)
        {
            DbDataReader dr = null;
            if (null != connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                dr = cmd.ExecuteReader();
                dr.Close();
            }
        }

        public DataSet getDataSet(string sqlStatement)
        {
            DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database  specified by properties file
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlStatement, connection);
            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            //return the dataSet
            return dataSet;
        }
    }

}
