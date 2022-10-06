using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vets_app
{
    public partial class appointmentManagerFrm : Form
    {
        private int appointmentId;
        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlDataAdapter myAdapter;
        private int petId;
        private int selectedMedicationId;
        DataSet ds;


    public appointmentManagerFrm(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
        }

        private void appointmentManagerFrm_Load(object sender, EventArgs e)
        {
            assemblePetWeightPanel();
            assemblePescriptionPanel();

            

        }

        private void addPetWeightButton_Click(object sender, EventArgs e)
        {
            //the inputted weight to add to the pet_weights table
            int petWeightToAdd = Convert.ToInt32(addPetWeightTextBox.Text);


            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();

            // Set the connection for the database command
            cmd.Connection = dbConnector.getConnect();

        
            //SQL command to insert the new weight
            cmd.CommandText = "INSERT INTO pet_weights (pet_id, weight, date) VALUES (" + petId + "," + petWeightToAdd + ", CURDATE());";

            MySqlDataReader mySqlReader;
            mySqlReader = cmd.ExecuteReader();

            //close the mySqlReader
            mySqlReader.Close();

            // Pop up a message box to show that the insert action has been completed
            MessageBox.Show("Weight Added");

            dataPetWeightsList.Refresh();
            myAdapter.Fill(ds);
            dataPetWeightsList.DataSource = ds.Tables[0];



        }

        public void assemblePetWeightPanel()
        {
            // Open the database connection
            dbConnector.db_connection();

            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();

            // Set the connection for the database command
            cmd.Connection = dbConnector.getConnect();

            //Extract the pet_id of the current appointment
            cmd.CommandText = "SELECT pet_id FROM appointments WHERE appointment_id=" + appointmentId;

            //execute and read the SQL command
            MySqlDataReader mySqlReader = cmd.ExecuteReader();
            mySqlReader.Read();

            //store the result in a true of false boolean that signals a successful login
            petId = mySqlReader.GetInt32(0);
            //close the mySqlReader
            mySqlReader.Close();

            // Create a new adapter to hold the output from the query
            myAdapter = new MySqlDataAdapter();

            cmd.CommandText = "SELECT weight as Weight, date as Date FROM pet_weights WHERE pet_id=" + petId;

            // Set the MySql command for the adapter
            myAdapter.SelectCommand = cmd;

            // Create a new data set to hold the data
            ds = new DataSet();

            // Fill the data set sith the data from the query
            myAdapter.Fill(ds);

            // Output the data set to the table
            dataPetWeightsList.DataSource = ds.Tables[0];
        }

        public void assemblePescriptionPanel()
        {
            // Open the database connection
            dbConnector.db_connection();

            addDataToComboBox("SELECT name as result fROM medications WHERE pescription=1", medicationNameComboBox);

            //extract which medication has been selected


        }
        /// <summary>
        /// Method that adds the result of a single column query to a combo box
        /// </summary>
        /// <param name="query"></param>
        /// <param name="comboBox"></param>

        public void addDataToComboBox(string query, ComboBox comboBox)
        {
            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();

            // Set the connection for the database command
            cmd.Connection = dbConnector.getConnect();

            cmd.CommandText = query;

            using (MySqlDataReader mySqlReader = cmd.ExecuteReader())
            {
                while (mySqlReader.Read())
                {
                    comboBox.Items.Add(mySqlReader.GetString("result"));


                }

            }
        }
        

        public void findIdOfSelection(string searchString, string tableName, string fieldName)
        {
            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();

            // Set the connection for the database command
            cmd.Connection = dbConnector.getConnect();

            cmd.CommandText = "SELECT " + tableName + "_id AS 'ID' FROM " + tableName + "s WHERE " + fieldName + "='" + searchString +"';";

            /*cmd.CommandText = "SELECT medication_id as 'ID' FROM medications WHERE name ='Drontal Puppy Liquid Wormer'";*/

            using (MySqlDataReader mySqlReader = cmd.ExecuteReader())
            {
                while (mySqlReader.Read())
                {
                    selectedMedicationId = mySqlReader.GetInt32("ID");
                }
            }
        }

        /// <summary>
        /// Method that that is triggered when a medication is selected from the medicationNameComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medicationNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //update the medication sizes combo box with associated sizes
            findIdOfSelection(medicationNameComboBox.Text, "medication", "name");
            /*addDataToComboBox("SELECT name as result fROM medications WHERE pescription=1", medicationNameComboBox);*/

            MessageBox.Show(selectedMedicationId.ToString());

            //reset the medicationSizeComboBox when a medication is selected
            medicationSizeComboBox.Items.Clear();
            //clear the text of the medicationSizeComboBox
            medicationSizeComboBox.Text = "";

            //update the medicationSizeComboBox with the associated sizes for the currently selected medicine
            addDataToComboBox("SELECT description AS result FROM medication_sizes WHERE medication_size_id=" + selectedMedicationId, medicationSizeComboBox);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
