using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace Ui_Layer
{
    public partial class Chef_ui : Form
    {
        Food_services fs;
        public Chef_ui()
        {
            InitializeComponent();
            fs = new Food_services();
        }

        private void cheff_back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            Program.ui.Show();
            
        }

        private void Chef_ui_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        public void Chef_ui_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fs.Get_order();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fs.Get_order();
        }
    }
}
