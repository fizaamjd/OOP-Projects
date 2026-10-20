using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.stockBL;
using thiscmsapp2.userBL;

namespace thiscmsapp2.Forms
{
    public partial class Custoptionsform : Form
    {
        private myCustomer cust;
        public Custoptionsform(myCustomer cust)
        {
            InitializeComponent();
            this.cust = cust;
        }
        public Custoptionsform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Custopt3 opt3 = new Custopt3();
            opt3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Custopt4 opt4 = new Custopt4();
            opt4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Custopt5part1 opt5 = new Custopt5part1();
            opt5.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Signinform signinform = new Signinform();
            signinform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Custoopt1 op1 = new Custoopt1();
            op1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Custopt2 op2 = new Custopt2();
            op2.Show();
            this.Hide();
        }

        private void Custoptionsform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
