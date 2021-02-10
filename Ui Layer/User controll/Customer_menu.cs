using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;

namespace Ui_Layer.User_controll
{
    public partial class Customer_menu : UserControl
    {
        Food_services fs;
        Customer_menu cm;
        
        public Customer_menu()
        {
            InitializeComponent();
            indi.Height = menu_btn1.Height;
            indi.Top = menu_btn1.Top;
            fs = new Food_services();
 
        }


        

        

        public void menu_btn1_Click(object sender, EventArgs e)
        {
            indi.Height = menu_btn1.Height;
            indi.Top = menu_btn1.Top;
        
         menu_changer1.Menu_changer_Load1(this, EventArgs.Empty,1);



        }

        private void Menu_changer1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menu_btn2_Click(object sender, EventArgs e)
        {
            indi.Height = menu_btn2.Height;
            indi.Top = menu_btn2.Top;
           
            Menu_changer m = new Menu_changer();
            menu_changer1.Menu_changer_Load1(this, EventArgs.Empty, 2);






        }

        private void menu_btn3_Click(object sender, EventArgs e)
        {
            indi.Height = menu_btn3.Height;
            indi.Top = menu_btn3.Top;
            Menu_changer m = new Menu_changer();
            menu_changer1.Menu_changer_Load1(this, EventArgs.Empty, 3);

        }

        private void menu_btn4_Click(object sender, EventArgs e)
        {
            indi.Height = menu_btn4.Height;
            indi.Top = menu_btn4.Top;
            menu_changer1.Menu_changer_Load1(this, EventArgs.Empty, 4);




        }

        private void Indi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_main_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void menu_changer1_Load(object sender, EventArgs e)
        {

        }
    }
}
