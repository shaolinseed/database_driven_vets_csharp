using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace vets_app
{
    public partial class loginForm : Form
    {

        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlConnection connect;


        public loginForm()
        {
            InitializeComponent();
        }

        private string computeMd5Hash(string input)
        {
            //   MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();


        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            //store the staff's login details in email and password variables
            String email = emailTextBox.Text;
            String password = computeMd5Hash(passwordTextBox.Text);

            //form a connection with the database
            dbConnector.db_connection();
            connect = dbConnector.getConnect();

            //create a SQL command to validate the staff credentials
            MySqlCommand cmd = new MySqlCommand();
            //Extract the count of the entries in the staff table that have matching login details
            cmd.CommandText = "SELECT COUNT(password) FROM staff WHERE staff.active=1 AND staff.email = '" + email + "' AND staff.password = '" + password + "'";
            cmd.Connection = connect;

            //execute and read the SQL command
            MySqlDataReader mySqlReader = cmd.ExecuteReader();
            mySqlReader.Read();
            //store the result in a true of false boolean that signals a successful login
            bool successfulLogin = Convert.ToBoolean(mySqlReader.GetInt32(0));
            //close the mySqlReader
            mySqlReader.Close();




            //correct login details (present in staff table)
            if (successfulLogin)
            {


                //setup static variables so the rest of the forms will know who is currently logged in

                Static_Variables.loggedInUserEmail = email;

                //find the staff ID from the provided staff email
                cmd.CommandText = "SELECT staff_id FROM staff WHERE email LIKE '%" + email + "%'";
                mySqlReader = cmd.ExecuteReader();
                mySqlReader.Read();
                int staffId = mySqlReader.GetInt32(0);
                mySqlReader.Close();

                cmd.CommandText = "SELECT first_name FROM staff WHERE staff_id=" + staffId;
                mySqlReader = cmd.ExecuteReader();
                mySqlReader.Read();
                string staffName = mySqlReader.GetString(0);
                mySqlReader.Close();

                cmd.CommandText = "SELECT position FROM staff WHERE staff_id=" + staffId;
                mySqlReader = cmd.ExecuteReader();
                mySqlReader.Read();
                string staffPosition = mySqlReader.GetString(0);
                mySqlReader.Close();

                //if pracititioner
                if (string.Equals(staffPosition, "Practitioner"))
                {
                    //display the practitioner home form
                    practitionerHomeFrm practitionerHomeFrm = new practitionerHomeFrm();
                    practitionerHomeFrm.Show();
                }
                //if receptionist
                else if (string.Equals(staffPosition, "Receptionist"))
                {
                    //display the receiptionist home form


                }
                //if stock control manager
                else if (string.Equals(staffPosition, "Stock Control Manager"))
                {

                    //display the stock manager home form
                    stockManagerForm stockManagerForm = new stockManagerForm();
                    stockManagerForm.Show();

                }



                Static_Variables.loggedInUserId = staffId;



                this.Close();
            }
            //incorrect login details
            else
            {
                MessageBox.Show("Incorrect Login details - please try again");
            }
        }
    }
}
