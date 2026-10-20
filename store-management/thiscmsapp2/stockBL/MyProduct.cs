using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiscmsapp2.stockBL
{
    public class MyProduct
    {
        protected string name;
        public Category pcategory { get; set; }
        protected string productID;
        public MyProduct(string name, Category pcategory)
        {
            this.name = name;
            this.pcategory = pcategory;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public string getID()
        {
            return productID;
        }
        public void setID(string id)
        {
            productID = id;
        }
    }

}

