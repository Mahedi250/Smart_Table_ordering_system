using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui_Layer.User_ui_layer
{
    public partial class User_home : UserControl
    {
        public User_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void enter_chef_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void enter_cus_btn_Click(object sender, EventArgs e)
        {
            Program.ui.Hide();
            new Customer_ui().Show();
        }

        private void enter_chef_btn_Click_1(object sender, EventArgs e)
        {
            Program.ui.Hide();
            Chef_ui x = new Chef_ui();
            x.Chef_ui_Load(this, EventArgs.Empty);
            x.Show();

        }
    }
}
