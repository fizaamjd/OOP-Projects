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
    public partial class Adminopt2 : Form
    {
        public Adminopt2()
        {
            InitializeComponent();
        }

        private void Adminopt2form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txttypebox.Focus();
        }

        private void txttypebox_Leave(object sender, EventArgs e)
        {
            if(Validations.Validatetype(txttypebox.Text.ToLower()) == false)
            {
                MessageBox.Show("Type should be eastern/western");
                txttypebox.Focus();
            }
            if (Validations.Validatetype(txttypebox.Text.ToLower()) == true)
            {
                txtwearbox.Focus();
            }

        }

        private void textwearbox_Leave(object sender, EventArgs e)
        {
           
            if (Validations.Validatetype(txttypebox.Text.ToLower()) == true)
            {
                txtprnamebox.Focus();
            }
            
            if (Validations.Validatewear(txtwearbox.Text.ToLower()) == false)
            {
                MessageBox.Show("Wear should be men/women/children");
                txtwearbox.Focus();
            }

        }

        private void textprnamebox_Leave(object sender, EventArgs e)
        {
            if (Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtprnamebox.Text.ToLower()) == true)
            {
                MessageBox.Show("Product already exist");
                txttypebox.Focus();
            }
            if (Validations.isProductexist(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower(), txtprnamebox.Text.ToLower()) == false)
            {
                txtprquantity.Focus();
            }

        }

        private void txtprquantity_Leave(object sender, EventArgs e)
        {
            if(Validations.Validateinteger(txtprquantity.Text)== false)
            {
                MessageBox.Show("Incorrect integer");
                txtprquantity.Focus();
            }
            if (Validations.Validateinteger(txtrtprice.Text) == true)
            {
                txtrtprice.Focus();
            }

        }

        private void txtrtprice_Leave(object sender, EventArgs e)
        {
            if (Validations.Validateinteger(txtrtprice.Text) == false)
            {
                MessageBox.Show("Incorrect integer");
                txtrtprice.Focus();
            }
            if (Validations.Validateinteger(txtrtprice.Text) == true)
            {
                txtcostprice.Focus();
            }

        }

        private void txtcostprice_Leave(object sender, EventArgs e)
        {
            if (Validations.Validateinteger(txtcostprice.Text) == false)
            {
                MessageBox.Show("Incorrect integer");
                txtcostprice.Focus();
            }
            if (Validations.Validateinteger(txtcostprice.Text) == true)
            {
                Category pcategory = new Category(txttypebox.Text.ToLower(), txtwearbox.Text.ToLower());
                MyProduct product = new MyProduct(txtprnamebox.Text.ToLower(), pcategory);
                Stock pstock = new Stock(product, int.Parse(txtprquantity.Text), int.Parse(txtrtprice.Text), int.Parse(txtcostprice.Text));
                myproductDL.Addtostock(pstock);
                myproductDL.isID(pstock.product);
                myproductDL.Productwriting();
                MessageBox.Show("Product added successfully");
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
