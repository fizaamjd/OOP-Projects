using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiscmsapp2.stockBL
{
    public class Stock
    {
        public MyProduct product { get; set; }
        protected int quantity;
        protected int retailprice;
        protected int costprice;
        protected int profit;
        protected string dateadded;
        public Stock(MyProduct product, int quantity, int retailprice, int costprice)
        {
            this.product = product;
            this.quantity = quantity;
            this.retailprice = retailprice;
            this.costprice = costprice;
            setDateadded();
        }
        public Stock(MyProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public void setRetailprice(int retailprice)
        {
            this.retailprice = retailprice;
        }
        public int getRetailprice()
        {
            return retailprice;
        }
        public void setCostprice(int costprice)
        {
            this.costprice = costprice;
        }
        public int getCostprice()
        {
            return costprice;
        }
        public void setDateadded()
        {
            DateTime date = DateTime.Now;
            string dateofproduct = date.ToString("MM/dd/yy");
            this.dateadded = dateofproduct;
        }
        public string getDateadded()
        {
            return dateadded;
        }
        public int getProfit()
        {
            int profit = costprice - retailprice;
            return profit;
        }
        public void setProfit(int profit)
        {
            this.profit = profit;
        }

    }



}

