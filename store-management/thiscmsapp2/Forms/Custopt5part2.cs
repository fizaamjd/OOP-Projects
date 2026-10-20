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

namespace thiscmsapp2.Forms
{
    public partial class Custopt5part2 : Form
    {

        public Custopt5part2()
        {
            InitializeComponent();
        }

        private void Custopt5part2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            foreach (var s in Signinform.getcustomer().GetCart())
            {
                datagridCart.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getCostprice());
            }
            lblshowbill.Text = "Your bill is " + Signinform.getcustomer().getBill().ToString() + "Rs only";
            lblshowbill.Visible = true;
        }
    }
}
