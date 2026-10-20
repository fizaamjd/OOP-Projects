using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiscmsapp2.userBL
{
    class myAdmin : myUser
    {
        public myAdmin(string name, string password) : base(name, password)
        {

        }
        public override string Getrole()
        {
            return "admin";
        }
        public override string toString()
        {
            string str = name + "," + password + "," + Getrole();
            return str;
        }

    }
}
