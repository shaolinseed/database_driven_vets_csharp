using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace vets_app
{
    public partial class homeFrm : Form
    {

        DatabaseConnector dbConnector = new DatabaseConnector();


        public homeFrm()
        {
            InitializeComponent();

            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        

        

        private void runQuery()
        {
            string query = textBox1.Text;

            if (query == "")
            {
                MessageBox.Show("Please insert a SQL query!");
                return;
            }

            string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=admin;password=vets_password;database=veterinary_centre";

            MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if(myReader.HasRows)
                {
                    MessageBox.Show("Your query generated results, please see console");

                    while (myReader.Read())
                    {                       //ID                            //first_name
                        Debug.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + 
                            //last_name                             //email
                            " - " + myReader.GetString(2) + " - " + myReader.GetString(3));

                        
                    }
                }
                else
                {
                    MessageBox.Show("Query successfully executed");
                }

                
            } catch(Exception e)
            {
                MessageBox.Show("Query failed to execute: " + e.Message);
            }
                


        }

        private void staff_Click(object sender, EventArgs e)
        {
            //display the stock manager home form
            staffLoginFrm staffLoginFrm = new staffLoginFrm();
            staffLoginFrm.Show();
            this.Close();

            


        }

        private void executeQueryButtonClick(object sender, EventArgs e)
        {
            Debug.WriteLine("HEEELE");
            runQuery();

        }

        private void connectDbButton_Click(object sender, EventArgs e)
        {
            if (dbConnector.db_connection())
            {
                MessageBox.Show("Excellent...");
            }
        }
       

      

       
    }
}
