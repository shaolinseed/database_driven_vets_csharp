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
    public partial class stockManagerForm : Form
    {
        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlConnection connect;
        private MySqlDataAdapter myAdapter;

        public stockManagerForm()
        {
            InitializeComponent();
        }

        private void stockManagerFormLoad(object sender, EventArgs e)
        {
            // Open the database connection
            dbConnector.db_connection();
            // Create a new database command
            MySqlCommand cmd = new MySqlCommand();
            // Set the query in the database command
            cmd.CommandText = "CALL selectLowStockMedications";
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
            dataLowStockList.DataSource = ds.Tables[0];

        }

        private void dataLowStockList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             /*int selectedAppointmentId = Convert.ToInt32(dataTodaysAppointmentsList.CurrentRow.Cells["appointment_id"].Value);
            MessageBox.Show(selectedAppointmentId.ToString());*/

            string selectedMedicationName = dataLowStockList.CurrentRow.Cells["Medication"].Value.ToString();
            MessageBox.Show(selectedMedicationName.ToString());
            
        }
    }
}
