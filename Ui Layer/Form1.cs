using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui_Layer
{
    public partial class Customer_ui : Form
    {
        public Customer_ui()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            customer_menu1.Visible = false;
            customer_cart1.Visible = false;
            customer_game1.Visible = false;
            customer_home1.Visible = false;
            customer_About_us1.Visible =true;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            customer_About_us1.Visible = false;
            customer_menu1.Visible = false;
            customer_cart1.Visible = false;
            customer_game1.Visible = false;
            customer_home1.Visible = true;
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            customer_home1.Visible = false;
            customer_cart1.Visible = false;
            customer_game1.Visible = false;
            customer_menu1.menu_btn1_Click(customer_menu1, EventArgs.Empty);
            customer_About_us1.Visible = false;

            customer_menu1.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            customer_home1.Visible = false;
            customer_menu1.Visible = false;
            customer_About_us1.Visible = false;
            customer_game1.Visible = false;
            customer_cart1.Visible = true;

        }

        private void time_pass_btn_Click(object sender, EventArgs e)
        {
            customer_home1.Visible = false;
            customer_menu1.Visible = false;
            customer_cart1.Visible = false;
            customer_About_us1.Visible = false;
            customer_game1.Visible = true;
        }
    }
}
