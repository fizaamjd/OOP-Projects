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
    public partial class Custoopt1 : Form
    {
        public Custoopt1()
        {
            InitializeComponent();
        }

        private void Custoopt1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtxnamebox.Focus();

        }
        private void back_Click(object sender, EventArgs e)
        {
            Custoptionsform cusopform = new Custoptionsform();
            cusopform.Show();
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

    }
}
