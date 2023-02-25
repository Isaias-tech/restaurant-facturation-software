using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_facturation_software.users
{
    internal static class Crud_Users
    {
        static public DataTable SignIn(string user, string password)
        {
            try
            {
                DataTable dt = DB_Connection.DBQuery($"EXEC SignIn '{user}', '{password}';");
                return dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error!");
                return null;
            }
        }
    }
}
