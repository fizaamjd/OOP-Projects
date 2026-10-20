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
    public partial class Adminsignupform : Form
    {
        public Adminsignupform()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            myAdmin adminobj = new myAdmin(txtxnamebox.Text.ToLower(), txtpswbox.Text);
            myUserDL.Addtolist(adminobj);
            myUser.setadminfilled();
            myUserDL.Filewriting();
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Hide();
        }

        private void txtxnamebox_Leave(object sender, EventArgs e)
        {
            if(Validations.Validatename(txtxnamebox.Text.ToLower()) == false)
            {
                MessageBox.Show("Invalid name");
                txtxnamebox.Focus();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Validations.Validatepassword(txtpswbox.Text) == false)
            {
                MessageBox.Show("Invalid password");
                txtpswbox.Focus();
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Validations.Validaterole(txtrolebox.Text.ToLower()) == false)
            {
                MessageBox.Show("Role should be admin");
                txtrolebox.Focus();
            }

        }

        private void Adminsignupform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized ;
            txtxnamebox.Focus();
        }
    }
}
