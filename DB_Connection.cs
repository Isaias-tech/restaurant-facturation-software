using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_facturation_software
{
    internal static class DB_Connection
    {
        public static DataTable DBQuery(string query)
        {
            try
            {
                string connectionString = "Data Source=ISAIASSANTIAGO;Initial Catalog=lvf;Integrated Security=True";
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }
    }
}
