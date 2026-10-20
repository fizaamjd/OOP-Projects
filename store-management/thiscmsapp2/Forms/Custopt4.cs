using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.stockDL;
using thiscmsapp2.userBL;

namespace thiscmsapp2.Forms
{
    public partial class Custopt4 : Form
    {
        public Custopt4()
        {
            InitializeComponent();
        }

        private void Custopt4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            foreach(var s in Signinform.getcustomer().GetCart())
            {
                datagridCart.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getCostprice());
            }
        }

        private void txtproductid_Leave(object sender, EventArgs e)
        {
            if(Validations.isProducuid(txtproductid.Text))
            {
                if(Signinform.getcustomer().delfromcart(txtproductid.Text))
                {
                    MessageBox.Show("Product removed from cart");
                    back.Focus();
                }
                else
                {
                    MessageBox.Show("Could not remove product");
                }
            }
            else
            {
                MessageBox.Show("Irrelevant product id");
                txtproductid.Focus();
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
