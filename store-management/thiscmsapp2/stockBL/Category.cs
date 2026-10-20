using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiscmsapp2.stockBL
{
    public class Category
    {
        protected string type;
        protected string wear;

        public Category(string type, string wear)
        {
            this.type = type;
            this.wear = wear;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return type;
        }
        public void setWear(string wear)
        {
            this.wear = wear;
        }
        public string getWear()
        {
            return wear;
        }
        public string getCategory()
        {
            return type + "," + wear;
        }
    }

}

    
