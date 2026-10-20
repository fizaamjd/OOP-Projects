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
using thiscmsapp2.stockDL;

namespace thiscmsapp2.Forms
{
    public partial class Adminopt8 : Form
    {
        public Adminopt8()
        {
            InitializeComponent();
        }

        private void txtnamebox_Leave(object sender, EventArgs e)
        {
            if (Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtnamebox.Text.ToLower()))
            {
                Category category = new Category(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower());
                MyProduct product = new MyProduct(txtnamebox.Text.ToLower(), category);
                if (myproductDL.delStock(product) == true)
                {
                    MessageBox.Show("Successful deletion");
                    myproductDL.Productwriting();
                }
                else
                {
                    MessageBox.Show("Could not delete stock");
                }
            }
            else
            {
                MessageBox.Show("Product does not exist");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Adminoptionsform adopform = new Adminoptionsform();
            adopform.Show();
            this.Hide();
        }

        private void Adminopt8_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txttypebox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txttypebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtwearbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void opt3panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
