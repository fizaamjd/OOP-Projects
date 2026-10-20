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
    public partial class Adminopt7 : Form
    {
        public Adminopt7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtnamebox.Text.ToLower()) == true)
            {
               Category category = new Category(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower());
               MyProduct product = new MyProduct(txtnamebox.Text.ToLower(), category);
               MessageBox.Show("The product was added on " + myproductDL.Givedateadded(product));
               back.Focus();
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

        private void Adminopt7_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txttypebox.Show();
        }

        private void txtnamebox_Leave(object sender, EventArgs e)
        {
            button4.Focus();
        }
    }
}
