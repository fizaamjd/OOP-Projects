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
    public partial class Adminopt5 : Form
    {
        public Adminopt5()
        {
            InitializeComponent();
        }

        private void txtupdquantity_Leave(object sender, EventArgs e)
        {
            if (Validations.Validateinteger(txtupdquantity.Text) == true)
            {
                if (Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtnamebox.Text.ToLower()))
                {

                    Category category = new Category(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower());
                    MyProduct product = new MyProduct(txtnamebox.Text.ToLower(), category);
                    if (myproductDL.Updquantity(product, int.Parse(txtupdquantity.Text)))
                    {
                        MessageBox.Show("Update successfull");
                        back.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Update unsuccessfull");
                        txttypebox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Product does not exist");
                }
            }
            else
            {
                MessageBox.Show("Invalid integer");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Adminoptionsform adopform = new Adminoptionsform();
            adopform.Show();
            this.Hide();

        }

        private void Adminopt5_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txttypebox.Focus();
        }
    }
}
