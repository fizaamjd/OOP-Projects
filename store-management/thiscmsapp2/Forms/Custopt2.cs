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

namespace thiscmsapp2.Forms
{
    public partial class Custopt2 : Form
    {
        public Custopt2()
        {
            InitializeComponent();
        }

        private void Custopt2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            foreach (var s in myproductDL.Getstock())
            {
                dataGridList.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getCostprice());
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
