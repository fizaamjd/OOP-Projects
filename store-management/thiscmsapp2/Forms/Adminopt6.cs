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
    public partial class Adminopt6 : Form
    {
        public Adminopt6()
        {
            InitializeComponent();
        }

        private void txtdelquantity_Leave(object sender, EventArgs e)
        {
            if (Validations.Validateinteger(txtdelquantity.Text) == true)
            {
                if (Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtnamebox.Text.ToLower()))
                {
                    Category category = new Category(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower());
                    MyProduct product = new MyProduct(txtnamebox.Text.ToLower(), category);
                    if (myproductDL.Deleteproduct(product, int.Parse(txtdelquantity.Text)) == true)
                    {
                        MessageBox.Show("Delete successfull");
                        myproductDL.Productwriting();
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

        private void Adminopt6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txttypebox.Show();
        }
    }
}
