using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.Forms;
using thiscmsapp2.userBL;

namespace thiscmsapp2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (myUser.checkadminfilled() == true)
            {
                Custsignupform custform = new Custsignupform();
                custform.Show();
                this.Hide();
            }
            if (myUser.checkadminfilled() == false)
            {
                Adminsignupform adminsignupform = new Adminsignupform();
                adminsignupform.Show();
                this.Hide();
                myUser.setadminfilled();
            }

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            Signinform signinform = new Signinform();
            signinform.Show();
            this.Hide();

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
