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
    public partial class staffHomeFrm : Form
    {
        private string staffName;
        public staffHomeFrm(string staffName)
        {
            InitializeComponent();
            this.staffName = staffName;
            setStaffName();
        }

        private void practitionerButton_Click(object sender, EventArgs e)
        {
            practitionerHomeFrm practitionerHomeFrm = new practitionerHomeFrm();
            practitionerHomeFrm.Show();
        }

        public void setStaffName()
        {
            welcomeLabel.Text += staffName;

        }

        
    }
    }
