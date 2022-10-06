using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace vets_app
{
    class DatabaseConnector
    {
        string mySQLConnectionString;
        MySqlConnection connect;
        // A method to create the database connection
        public bool db_connection()
        {
            try
            {
                mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=admin;password=vets_password;database=veterinary_centre";
                connect = new MySqlConnection(mySQLConnectionString);
                connect.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
                throw;
            }
        }
        public MySqlConnection getConnect()
        {
            return connect;

        }

       
    }
}
