using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using thiscmsapp2.stockDL;
using thiscmsapp2.userDL;

namespace thiscmsapp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            myUserDL.FileReading();
            myproductDL.Productreading();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcomeform());
        }
    }
}
