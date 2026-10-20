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
    public partial class Adminopt1 : Form
    {
        public Adminopt1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Adminoptionsform adopform = new Adminoptionsform();
            adopform.Show();
            this.Hide();
        }

        private void txtpswbox_Leave(object sender, EventArgs e)
        {
            myUser user = myUserDL.GetUser(txtxnamebox.Text.ToLower());
            if (user != null)
            {
                user.Setpassword(txtpswbox.Text);
                myUserDL.Filewriting();
                MessageBox.Show("Update successfull");
            }

        }

        private void Adminopt1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtxnamebox.Focus();

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtxnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpswbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
