using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.userBL;

namespace thiscmsapp2.userDL
{
    class myUserDL
    {
        public static List<myUser> Userslist = new List<myUser>();
        public static void Addtolist(myUser user)
        {
            Userslist.Add(user);
        }
        public static List<myUser> GetUserlist()
        {
            return Userslist;
        }
        public static void Filewriting()
        {
            string path = "users.txt";
            if (File.Exists(path))
            {
                StreamWriter filevariable = new StreamWriter(path, false);
                foreach (myUser u in Userslist)
                {
                    filevariable.WriteLine(u.Getname() + "," + u.Getpassword() + "," + u.Getrole());
                }
                filevariable.Flush();
                filevariable.Close();
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
        public static bool FileReading()
        {
            string record;
            string path = "users.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                while ((record = filevariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        continue;
                    }
                    string[] splitrecord = record.Split(',');
                    string name = splitrecord[0];
                    string pswrd = splitrecord[1];
                    if (splitrecord[2] == "admin")
                    {
                        myAdmin adminobj = new myAdmin(name, pswrd);
                        Addtolist(adminobj);
                        myUser.setadminfilled();
                    }
                    if (splitrecord[2] == "customer")
                    {
                        myCustomer customerobj = new myCustomer(name, pswrd);
                        Addtolist(customerobj);
                    }
                }
                filevariable.Close();
                return true;
            }
            return false;
        }
        public static myUser Getcorrectuser(string name, string password)
        {
            foreach (myUser u in Userslist)
            {
                if (name == u.Getname() && password == u.Getpassword())
                {
                    return u;
                }
            }
            return null;
        }
        public static myUser GetUser(string name)
        {
            foreach (myUser u in Userslist)
            {
                if (name == u.Getname())
                {
                    return u;
                }
            }
            return null;
        }



    }
}
