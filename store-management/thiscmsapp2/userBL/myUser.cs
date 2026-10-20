using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiscmsapp2.userBL
{
    public class myUser
    {
        protected string name;
        protected string password;
        public static bool isfilled;
        public myUser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public myUser()
        {

        }
        public myUser(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return name;
        }
        public void Setname(string name)
        {
            this.name = name;
        }
        public void Setpassword(string pswrd)
        {
            this.password = pswrd;
        }
        public string Getpassword()
        {
            return password;
        }
        public virtual string Getrole()
        {
            return "";
        }
        public virtual string toString()
        {
            string str = name + "," + password;
            return str;
        }
        public static bool checkadminfilled()
        {
            return isfilled;
        }
        public static void setadminfilled()
        {
            isfilled = true;
        }
    }

}

