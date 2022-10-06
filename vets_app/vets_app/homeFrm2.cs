using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vets_app
{
    public partial class homeFrm2 : Form
    {
        public homeFrm2()
        {
            InitializeComponent();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //display staffLoginFrm
            staffLoginFrm staffLoginFrm = new staffLoginFrm();

            staffLoginFrm.Show();
            
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            customerHomeFrm customerHomeFrm = new customerHomeFrm();
            customerHomeFrm.Show();
        }
    }
}
