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
    public partial class customerHomeFrm : Form
    {
        public customerHomeFrm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            customerRegisterFrm customerRegisterFrm = new customerRegisterFrm();
            customerRegisterFrm.Show();
        }
    }
}
