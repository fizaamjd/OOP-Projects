using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thiscmsapp2.stockDL;
using thiscmsapp2.userBL;
using thiscmsapp2.userDL;

namespace thiscmsapp2
{
    class Validations
    {
        public static bool isvalidpswrd;
        public static bool isvalidname;
        public static bool Validatename(string name)
        {
            if (isExist(name))
            {
                foreach (char c in name)
                {
                    if ((Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122) || (Convert.ToInt32(c) > 48 && Convert.ToInt32(c) <= 57) || c == '_')
                    {
                        isvalidname = true;
                    }
                    else
                    {
                        isvalidname = false;
                        break;
                    }
                }
            }
            return isvalidname;

        }
        public static bool Validatepassword(string pswrd)
        {
            if (pswrd.Length > 5)
            {

                foreach (char p in pswrd)
                {
                    if ((Convert.ToInt32(p) >= 97 && Convert.ToInt32(p) <= 122) || (Convert.ToInt32(p) > 48 && Convert.ToInt32(p) <= 57) || p == '_')
                    {
                        isvalidpswrd = true;
                    }
                    else
                    {
                        isvalidpswrd = false;
                        break;

                    }
                }
            }
            else
            {
                isvalidpswrd = false;
            }

            return isvalidpswrd;
        }
        public static bool isNull(string userstring)
        {
            if (userstring == "" || userstring == " ")
            {
                return true;
            }
            return false;
        }
        public static bool Validaterole(string role)
        {
            if (role == "admin" || role == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isExist(string name)
        {
            foreach (myUser u in myUserDL.GetUserlist())
            {
                if (name == u.Getname())
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Validateinteger(string integer)
        {
            bool isvalid = false;
            for (int i = 0; i < integer.Length; i++)
            {
                if ((Convert.ToInt32(integer[i]) >= 48 && Convert.ToInt32(integer[i]) <= 57))
                {
                    isvalid = true;
                }
                else
                {
                    isvalid = false;
                    break;
                }
            }

            return isvalid;
        }
        public static bool Validatewear(string wear)
        {
            if (wear == "men" || wear == "women" || wear == "children")
            {
                return true;
            }
            return false;
        }
        public static bool Validatetype(string type)
        {
            if (type == "western" || type == "eastern")
            {
                return true;
            }
            return false;
        }
        public static bool isadmin(string role)
        {
            if (role == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool isValiduser(string name, string password)
        {
            foreach (myUser u in myUserDL.GetUserlist())
            {
                if (name == u.Getname() && password == u.Getpassword())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isProductexist(string type, string wear, string name)
        {
            foreach (var s in myproductDL.Getstock())
            {
                if (s.product.pcategory.getType() + s.product.pcategory.getWear() == type + wear && s.product.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isProducuid(string productid)
        {
            foreach (var s in myproductDL.Getstock())
            {
                if (s.product.getID() == productid)
                {
                    return true;
                }
            }
            return false;

        }


    }

}

