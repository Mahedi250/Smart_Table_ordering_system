using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui_Layer.User_ui_layer;

namespace Ui_Layer.User_ui_layer
{
    public partial class User_ui : Form
    {
        
        public User_ui()
        {
            InitializeComponent();
        }

        private void user_home_btn_Click(object sender, EventArgs e)
        {
            sell1.Visible = false;
            user_menu1.Visible = false;
            addemloyee1.Visible = false;
            user_home1.Visible = true;
           
            
            
            
        }

        private void uer_home1_Load(object sender, EventArgs e)
        {
           
        }

        private void menu_edit_btn_Click(object sender, EventArgs e)
        {
            sell1.Visible = false;
            addemloyee1.Visible = false;
            user_home1.Visible = false;
            user_menu1.Visible = true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void add_employee_btn_Click(object sender, EventArgs e)
        {
            sell1.Visible = false;
            user_home1.Visible = false;
            user_menu1.Visible = false;
            addemloyee1.Visible = true;
        }

        private void User_ui_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addemloyee1_Leave(object sender, EventArgs e)
        {

        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            user_home1.Visible = false;
            user_menu1.Visible = false;
            addemloyee1.Visible = false;
            sell1.Visible = true;
        }
    }
}
