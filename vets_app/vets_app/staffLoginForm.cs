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
    public partial class staffLoginFrm : Form
    {
        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlConnection connect;
        passwordHelper passwordHelper = new passwordHelper();



        public staffLoginFrm()
        {
            InitializeComponent();
        }

      

        private void loginButtonClick(object sender, EventArgs e)
        {
            //store the staff's login details in email and password variables
            String email = emailTextBox.Text;
            String password = passwordHelper.computeMd5Hash(passwordTextBox.Text);

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


            /*MessageBox.Show(count);*/



        }

        
    }
}
