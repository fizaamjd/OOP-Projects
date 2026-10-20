using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thiscmsapp2.Forms
{
    public partial class Adminoptionsform : Form
    {
        public Adminoptionsform()
        {
            InitializeComponent();
        }

        private void Adminoptionsform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminopt1 op1 = new Adminopt1();
            op1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adminopt2 op2 = new Adminopt2();
            op2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminopt3 op3 = new Adminopt3();
            op3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Adminopt4 op4 = new Adminopt4();
            op4.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Adminopt9 op9 = new Adminopt9();
            op9.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adminopt6 op6 = new Adminopt6();
            op6.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Signinform signinform = new Signinform();
            signinform.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminopt5 adop5 = new Adminopt5();
            adop5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adminopt7 adop7 = new Adminopt7();
            adop7.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Adminopt8 adop8 = new Adminopt8();
            adop8.Show();
            this.Hide();
        }
    }
}
