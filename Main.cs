using restaurant_facturation_software.cart;
using restaurant_facturation_software.drinks;
using restaurant_facturation_software.menu;
using restaurant_facturation_software.reservations;
using restaurant_facturation_software.users;
using restaurant_facturation_software.wines;
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

        private void btn_admin_panel_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.ShowDialog();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Carts cart = new Carts();
            cart.ShowDialog();
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.ShowDialog();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.ShowDialog();
        }

        private void btn_wines_Click(object sender, EventArgs e)
        {
            Wines wines = new Wines();
            wines.ShowDialog();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Menu_items mi = new Menu_items();
            mi.ShowDialog();
        }
    }
}
