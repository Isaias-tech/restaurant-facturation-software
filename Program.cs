using restaurant_facturation_software.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_facturation_software
{
    internal static class Program
    {
        static public Form_Sign_In form_sign_in;
        static public User CurrentUser;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_sign_in = new Form_Sign_In();
            Application.Run(form_sign_in);
        }
    }
}
