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
    public partial class Adminopt9 : Form
    {
        public Adminopt9()
        {
            InitializeComponent();
        }

        private void Adminopt9_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            foreach(var s in myproductDL.Getstock())
            {
                dataGridView1.Rows.Add(s.product.getID(), s.product.pcategory.getType(), s.product.pcategory.getWear(), s.product.getName(), s.getQuantity(), s.getRetailprice(),
                    s.getCostprice(), s.getDateadded(), s.getProfit());

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Adminoptionsform adopform = new Adminoptionsform();
            adopform.Show();
            this.Hide();
        }
    }
}
