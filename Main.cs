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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form_sign_in.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUser.Position != "Admin")
            {
                btn_admin_panel.Visible = false;
            }
        }
    }
}
