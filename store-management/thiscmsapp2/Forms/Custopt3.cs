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
using thiscmsapp2.userBL;

namespace thiscmsapp2.Forms
{
    public partial class Custopt3 : Form
    {
        public Custopt3()
        {
            InitializeComponent();
             
        }

        private void Custopt3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            foreach (var s in myproductDL.Getstock())
            {
                dataGridView1.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getCostprice());
            }
        }

        private void txtproductid_Leave(object sender, EventArgs e)
        {
            if (Validations.isProducuid(txtproductid.Text) == false)
            {
                MessageBox.Show("Incorrect id");
                txtproductid.Focus();
            }
            else
            {
                txtquantity.Focus();
            }
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            if (Validations.Validateinteger(txtquantity.Text))
            {
                Stock s = Signinform.getcustomer().Getrelavantproduct(txtproductid.Text);
                if (s != null)
                {
                    if (s.getQuantity() > 0)
                    {
                      s.setQuantity(int.Parse(txtquantity.Text));
                      Signinform.getcustomer().AddCart(s);
                      MessageBox.Show("Product added");
                    }
                    else
                    {
                        MessageBox.Show("Product is out of stock");
                    }
                }
                else
                {
                    MessageBox.Show("Irrelevant product ID");
                    txtproductid.Focus();
                }
            }
            else
            {
                MessageBox.Show("Incorrect integer");
                txtquantity.Focus();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Custoptionsform custform = new Custoptionsform();
            custform.Show();
            this.Hide();
        }
    }
}
