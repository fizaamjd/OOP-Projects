using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.Forms;
using thiscmsapp2.stockDL;
using thiscmsapp2.userBL;

namespace thiscmsapp2.stockBL
{
    public partial class Custopt5part1 : Form
    {
        public Custopt5part1()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Decreasestock();
            Custopt5part2 part2 = new Custopt5part2();
            part2.Show();
            this.Hide();
        }

        private void Custopt5part1_Load(object sender, EventArgs e)
        {
            datagridCart.Rows.Clear();
            this.WindowState = FormWindowState.Maximized;
            foreach (var s  in Signinform.getcustomer().GetCart())
            {
                datagridCart.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getCostprice());
            }
            datagridCart.Refresh();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Custoptionsform custform = new Custoptionsform();
            custform.Show();
            this.Hide();
        }
    private void Decreasestock()
    {
        foreach (var s in myproductDL.Getstock())
        {
            foreach (var c in Signinform.getcustomer().GetCart())
            {
                if (s.product.getID() == c.product.getID())
                {
                    s.setQuantity(s.getQuantity() - c.getQuantity());
                    break;
                }
            }
            myproductDL.Productwriting();
        }
    }
    }

}
