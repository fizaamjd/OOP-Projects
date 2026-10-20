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
    public partial class Signinform : Form
    {
        public static myCustomer cust;
        public Signinform()
        {
            InitializeComponent();
        }

        private void Signinform_Load(object sender, EventArgs e)
        {
            txtxnamebox.Focus();
            this.WindowState = FormWindowState.Maximized;
        }
        private void txtpswbox_Leave(object sender, EventArgs e)
        {
            if(Validations.isValiduser(txtxnamebox.Text.ToLower(), txtpswbox.Text) == false)
            {
                MessageBox.Show("Unsuccessfull signin");
            }
            if (Validations.isValiduser(txtxnamebox.Text.ToLower(), txtpswbox.Text) == true)
            {
                MessageBox.Show("Successfull signin");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            if(myUserDL.Getcorrectuser(txtxnamebox.Text.ToLower(), txtpswbox.Text).Getrole() == "admin")
            {
                Adminoptionsform adform = new Adminoptionsform();
                adform.Show();
                this.Hide();
            }
            if (myUserDL.Getcorrectuser(txtxnamebox.Text.ToLower(), txtpswbox.Text).Getrole() == "customer")
            {
                myCustomer customer = new myCustomer(txtxnamebox.Text.ToLower(), txtpswbox.Text);
                Signinform.cust = customer;
                Custoptionsform custform = new Custoptionsform(cust);
                custform.Show();
                this.Hide();
            }

        }
        public static myCustomer getcustomer()
        {
            return Signinform.cust;
        }
    }
}
