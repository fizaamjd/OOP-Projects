using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thiscmsapp2.stockBL;
using thiscmsapp2.stockDL;

namespace thiscmsapp2.userBL
{
    public class myCustomer : myUser
    {
        public List<Stock> customercart = new List<Stock>();
        public myCustomer(string name, string password) : base(name, password)
        {

        }
        public myCustomer(string name) : base(name)
        {

        }
        public myCustomer()
        {

        }
        public override string Getrole()
        {
            return "customer";
        }
        public override string toString()
        {
            string str = name + "," + password + "," + Getrole();
            return str;
        }
        public List<Stock> GetCart()
        {
            return customercart;
        }
        public void AddCart(Stock s)
        {
            customercart.Add(s);
        }
        public double getBill()
        {
            double bill = 0;
            foreach (var b in customercart)
            {
                bill = bill + (b.getCostprice() * b.getQuantity());
            }
            return bill;
        }
        public void setcartQuantity(int cartquantity)
        {
            foreach (var v in customercart)
            {
                v.setQuantity(cartquantity);
            }
        }
        public int getcartQuantity()
        {
            foreach (var v in customercart)
            {
                return v.getQuantity();
            }
            return 0;
        }
        public bool delfromcart(string id)
        {
            foreach (var c in customercart)
            {
                if (c.product.getID() == id)
                {
                    customercart.Remove(c);
                    return true;
                }
            }
            return false;
        }
        public Stock Getrelavantproduct(string id)
        {
            foreach (var s in myproductDL.Getstock())
            {
                if (s.product.getID() == id)
                {

                    Stock pstock = new Stock(s.product, s.getQuantity(), s.getRetailprice(), s.getCostprice());
                    return pstock;
                }
            }
            return null;
        }

    }

}

