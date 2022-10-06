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
    public partial class customerRegisterFrm : Form
    {

        passwordHelper passwordHelper = new passwordHelper();

        // Create list of customer field text boxes
        List<TextBox> customerTextBoxList = new List<TextBox>();

        // Create list of pet field text boxes
        List<TextBox> petTextBoxList = new List<TextBox>();

        DatabaseConnector dbConnector = new DatabaseConnector();
        // the properties that will hold the database connection
        private MySqlConnection connect;

        



        public customerRegisterFrm()
        {
            InitializeComponent();

            //add customer textbox fields to list 
            customerTextBoxList.AddRange(new List<TextBox>
            { 
                firstNameTextBox,
                lastNameTextBox,
                emailTextBox,
                passwordTextBox,
                repeatTextBox
            });
            //add pet textbox fields to list
            petTextBoxList.AddRange(new List<TextBox>
            {
                petNameTextBox,
                lastNameTextBox,
                emailTextBox,
                passwordTextBox,
                repeatTextBox
            });

            
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {




            foreach (TextBox customerTextBox in customerTextBoxList)
            {
                if (utils.checkIfTextBoxEmpty(customerTextBox))
                {
                    string textBoxString = customerTextBox.Name.ToString();
                    textBoxString = utils.RemoveFromEnd(textBoxString, "TextBox");
                    textBoxString = utils.ToSentenceCase(textBoxString);
                    textBoxString = utils.FirstLetterCapital(textBoxString);

                    customerErrorLabel.Text = textBoxString + " required";

                    return;

                }
            }
            if (firstNameTextBox.Text.All(char.IsDigit))
            {
                customerErrorLabel.Text = "First name" + " cannot contain numbers";

            }
            if (lastNameTextBox.Text.All(char.IsDigit))
            {
                customerErrorLabel.Text = "First name" + " cannot contain numbers";

            }

            //if the passwords provided are valid 
            if (passwordHelper.validatePassword(passwordTextBox.Text, repeatTextBox.Text) == "valid")
            {
                customerErrorLabel.Text = "Success";
            } 
            else
            {
                customerErrorLabel.Text = passwordHelper.validatePassword(passwordTextBox.Text, repeatTextBox.Text);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
  


            if (Check_Value_In_Column(emailTextBox.Text, "email", "customers"))
            {
                MessageBox.Show("exists");
            } 


            
           

            
        }
        private bool Check_Value_In_Column(string searchValue, string column, string table)
        {
            bool result;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.connect;

            cmd.CommandText = "SELECT COUNT(email) AS exist FROM customers WHERE email=@searchValue;";

            cmd.Parameters.Add("@searchValue", MySqlDbType.VarChar).Value = searchValue;
            cmd.Parameters.Add("@column", MySqlDbType.VarChar).Value = column;
            cmd.Parameters.Add("@table", MySqlDbType.VarChar).Value = table;

            /* using (MySqlDataReader mySqlReader = cmd.ExecuteReader())
             {
                 while (mySqlReader.Read())
                 {

                     result = mySqlReader.GetBoolean("exist");


                 }

             }*/

            MySqlDataReader mySqlReader = cmd.ExecuteReader();
            mySqlReader.Read();
            result = mySqlReader.GetBoolean("exist");
            mySqlReader.Close();
            return result;

        }


        private void customerRegisterFrm_Load(object sender, EventArgs e)
        {
            //form a connection with the database
            dbConnector.db_connection();
            connect = dbConnector.getConnect();
        }
    }
}
