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
    public partial class Menu_changer : UserControl
    {
        Food_services fs;
        int id;
        List<Entities.Menu> items;

        public Menu_changer()
        {

            InitializeComponent();
            fs = new Food_services();
            this.id = 1;
 
        }
        public Menu_changer(int id)
        {
            fs = new Food_services();
            this.id = id;
            InitializeComponent();

      
            

        }

        public void Menu_changer_Load1(object sender, EventArgs e,int id)
        {

            this.Refresh();
            menu_panel.Controls.Clear();
            Add_menu(id);
            this.Show();
        }

        public void Add_menu(int cat_id)
        {
           


                items = new List<Entities.Menu>();

                items = fs.Get_menu_by_id(cat_id);



                for (int j = 0; j < items.Count; j++)
                {
               
                    User_controll.Menu_box menu = new User_controll.Menu_box();

                if (items[j].Food_avl !=1)
                {
                    menu.sold_out.Visible = true;



                }
                else {


                    menu.sold_out.Visible = false;

                }
                menu.food_id = items[j].Food_Id;
                menu.food_name_lbl.Text = items[j].Food_Name;
                    menu.price_lbl.Text = items[j].Food_Price.ToString()+"৳";
                    menu.label1.Text = items[j].Food_Details;
                    //Image img = Image.FromFile(items[i].Food_path);
                    menu.pictureBox1.Image = items[j].Food_photo;
                    menu_panel.Controls.Add(menu);
                if (items[j].Food_avl != 0) {

                    menu.Click += new EventHandler(this.Menu_box_click);


                }

                }




        }

        private void Menu_box_click(object sender, EventArgs e) {

            Menu_box menu = (Menu_box)sender;
           
            List<Ing> ings = fs.Get_food_extra_ing(menu.food_id);



            Menu_infocs m = new Menu_infocs(menu.food_name_lbl.Text, menu.price_lbl.Text, menu.label1.Text,ings,menu.food_id);
            m.Show();



        }

        private void Menu_changer_Load(object sender, EventArgs e)
        {
            
        }

        public void menu_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Menu_changer_Load1(this, EventArgs.Empty,3);
        }
    }

}
    

