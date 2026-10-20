using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.userBL;
using thiscmsapp2.userDL;

namespace thiscmsapp2.Forms
{
    public partial class Custsignupform : Form
    {
        public Custsignupform()
        {
            InitializeComponent();
        }

        private void txtxnamebox_Leave(object sender, EventArgs e)
        {
            if (Validations.Validatename(txtxnamebox.Text.ToLower()) == false)
            {
                MessageBox.Show("Invalid name");
                txtxnamebox.Focus();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            myCustomer custobj = new myCustomer(txtxnamebox.Text.ToLower(), txtpswbox.Text);
            myUserDL.Addtolist(custobj);
            myUser.setadminfilled();
            myUserDL.Filewriting();
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Hide();

        }

        private void txtpswbox_Leave(object sender, EventArgs e)
        {
            if (Validations.Validatepassword(txtpswbox.Text) == false)
            {
                MessageBox.Show("Invalid password");
                txtpswbox.Focus();
            }
        }

        private void Custsignupform_Load(object sender, EventArgs e)
        {
            txtxnamebox.Focus();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
