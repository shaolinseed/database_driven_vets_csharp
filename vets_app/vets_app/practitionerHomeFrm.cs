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
    public partial class practitionerHomeFrm : Form
    {

        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlDataAdapter myAdapter;

        private String appointmentStatusSearch = "Open";



        public practitionerHomeFrm()
        {
            InitializeComponent();
        }

        

        // When the form loads display all the data from the customer table
        private void practitionerFormLoad(object sender, EventArgs e)
        {
            // Open the database connection
            dbConnector.db_connection();
            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();
            // Set the query in the database command
            /*  cmd.CommandText = "SELECT * FROM appointments WHERE date = CURDATE() AND status LIKE '%Open%' AND staff_id =" + Static_Variables.loggedInUserId + " ORDER BY start_time ASC;";*/


            cmd.CommandText = "CALL listPractitionerAppointments(" + Static_Variables.loggedInUserId + ", CURDATE(), 'Open')";
            // Set the connection for the database command
            cmd.Connection = dbConnector.getConnect();

            // Create a new adapter to hold the output from the query
            myAdapter = new MySqlDataAdapter();

            // Set the MySql command for the adapter
            myAdapter.SelectCommand = cmd;

            // Create a new data set to hold the data
            DataSet ds = new DataSet();

            // Fill the data set sith the data from the query
            myAdapter.Fill(ds);

            // Output the data set to the table
            dataTodaysAppointmentsList.DataSource = ds.Tables[0];

        }

        // When we make a change update the table in the database
        private void dataTodaysAppointmentsList_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Only update the table where there have been changes
            DataTable changes = ((DataTable)dataTodaysAppointmentsList.DataSource).GetChanges();

            // As long as there were some changes
            if (changes != null)
            {
                // Automatically work out the update query

                // Create a new auto command (query) builder
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(myAdapter);
                // Update the query based on what has happened in the table (update or insert)
                myAdapter.UpdateCommand = mcb.GetUpdateCommand();
                myAdapter.Update(changes);

                // Run the query to make the changes
                ((DataTable)dataTodaysAppointmentsList.DataSource).AcceptChanges();
            }
        }

        private void openAppointmentButton_Click(object sender, EventArgs e)
        {
           
                /*MessageBox.Show(dataTodaysAppointmentsList.SelectedRows[0].ToString());*/
                int selectedAppointmentId = Convert.ToInt32(dataTodaysAppointmentsList.CurrentRow.Cells["ID"].Value);
                appointmentManagerFrm appointmentManagerFrm = new appointmentManagerFrm(selectedAppointmentId);
                appointmentManagerFrm.Show();
           

        }
    }
}
