using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.stockBL;

namespace thiscmsapp2.stockDL
{
    class myproductDL
    {
        static List<Stock> stockproducts = new List<Stock>();
        public static void Addtostock(Stock p)
        {
            stockproducts.Add(p);
        }
        public static List<Stock> Getstock()
        {
            return stockproducts;
        }
        public static bool Updretailprice(MyProduct product, int newretailprice)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getCategory() == product.pcategory.getCategory() && s.product.getName() == product.getName())
                {
                    s.setRetailprice(newretailprice);
                    Productwriting();
                    return true;
                }
            }
            return false;
        }
        public static bool Updcostprice(MyProduct product, int newcostprice)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getCategory() == product.pcategory.getCategory() && s.product.getName() == product.getName())
                {
                    s.setCostprice(newcostprice);
                    Productwriting();
                    return true;
                }
            }
            return false;
        }
        public static bool Updquantity(MyProduct product, int newquantity)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getCategory() == product.pcategory.getCategory() && s.product.getName() == product.getName())
                {
                    s.setQuantity(newquantity);
                    Productwriting();
                    return true;
                }
            }
            return false;
        }
        public static string Givedateadded(MyProduct product)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getCategory() == product.pcategory.getCategory() && s.product.getName() == product.getName())
                {
                    return s.getDateadded();
                }
            }
            return null;
        }
        public static bool Deleteproduct(MyProduct product, int quantity)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getCategory() == product.pcategory.getCategory() && s.product.getName() == product.getName())
                {
                    s.setQuantity(s.getQuantity() - quantity);
                    return true;
                }
            }
            return false;
        }
        public static void Productwriting()
        {
            string path = "products.txt";
            if (File.Exists(path))
            {
                StreamWriter filevariable = new StreamWriter(path, false);
                foreach (Stock s in stockproducts)
                {
                    filevariable.WriteLine(s.product.getID() + "," + s.product.pcategory.getCategory() + "," + s.product.getName() + "," + s.getQuantity()
                    + "," + s.getRetailprice() + "," + s.getCostprice() + "," + s.getDateadded() + "," + s.getProfit());
                }
                filevariable.Flush();
                filevariable.Close();
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
        public static void Productreading()
        {
            string path = "products.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        continue;
                    }
                    string[] splitrecord = record.Split(',');
                    string id = splitrecord[0];
                    string type = splitrecord[1];
                    string wear = splitrecord[2];
                    string name = splitrecord[3];
                    int quantity = int.Parse(splitrecord[4]);
                    int retailprice = int.Parse(splitrecord[5]);
                    int costprice = int.Parse(splitrecord[6]);
                    string dateadded = splitrecord[7];
                    int profit = int.Parse(splitrecord[8]);
                    Category pcategory = new Category(type, wear);
                    MyProduct product = new MyProduct(name, pcategory);
                    product.setID(id);
                    Stock pstock = new Stock(product, quantity, retailprice, costprice);
                    pstock.setProfit(profit);
                    Addtostock(pstock);
                }
                filevariable.Close();
            }
        }
        public static bool delStock(MyProduct product)
        {
            foreach (var s in stockproducts)
            {
                if (s.product.pcategory.getType() + s.product.pcategory.getWear() == product.pcategory.getType() + product.pcategory.getWear() && s.product.getName() == product.getName())
                {
                    stockproducts.Remove(s);
                    Productwriting();
                    return true;
                }
            }
            return false;

        }
        public static void AssignID(MyProduct product)
        {
            Random random = new Random();
            string id = "00X" + random.Next(10000).ToString();
            if (isavail(id) == false)
            {
                product.setID(id);

            }
            else
            {
                AssignID(product);
            }

        }

        public static void isID(MyProduct product)
        {
            foreach (var id in stockproducts)
            {
                if (id.product.getID() == product.getID())
                {
                    AssignID(product);
                }
            }
        }
        public static bool isavail(string id)
        {
            foreach (var existingid in stockproducts)
            {
                if (id == existingid.product.getID())
                {
                    return true;
                }
            }
            return false;
        }
    }


}
