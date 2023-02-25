using restaurant_facturation_software.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_facturation_software
{
    public partial class Form_Sign_In : Form
    {
        public Form_Sign_In()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            using (DataTable dt = Crud_Users.SignIn(txt_user.Text, txt_password.Text))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    User CU = new User(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToDateTime(dr[5]), Convert.ToBoolean(dr[6]), Convert.ToString(dr[7]));
                    Program.CurrentUser = CU;
                    this.Hide();
                    txt_user.Text = "";
                    txt_password.Text = "";
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Los valores incertados son incorrectos.", "Error!");
                }
            }
        }
    }
}
