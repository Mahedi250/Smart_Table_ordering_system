using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace Ui_Layer
{

    public partial class Menu_infocs : Form
    {
        int food_id;
        int counter = 1;
        int new_price = 0;
        int ing_count = 0;
        User_controll.Ing_box box;
        int price = 0;
        int main_price = 0;
        Food_services fs;




        public Menu_infocs()
        {
            InitializeComponent();
            quantity_lbl.Text = counter.ToString();
            fs = new Food_services();
        }
        public Menu_infocs(string food_name, string food_price, string food_des, List<Ing> ings,int food_id)
        {
            InitializeComponent();
            fs = new Food_services();
            quantity_lbl.Text = counter.ToString();
            this.food_id = food_id;
            food_name_lbl.Text = food_name;
            food_price_lbl.Text = food_price;
            new_price = Convert.ToInt32(food_price.Remove(food_price.Length - 1, 1));
            main_price = new_price;
            food_info_lbl.Text = food_des;

            for (int i = 0; i < ings.Count; i++)
            {
                box = new User_controll.Ing_box();
                box.checkBox1.Text = ings[i].Ing_name;
                box.label1.Text = ings[i].ing_price.ToString();
                exrta_in_panel.Controls.Add(box);
                box.Click += new EventHandler(this.Checkbox_click);



            }



        }


        public void eventchange(object sender, EventArgs e, User_controll.Ing_box box)
        {





        }

        public void Checkbox_click(object sender, EventArgs e)
        {
            price = 0;

            User_controll.Ing_box m = (User_controll.Ing_box)sender;




            price = Convert.ToInt16(m.label1.Text);

            main_price = Convert.ToInt32(this.food_price_lbl.Text.Remove(this.food_price_lbl.Text.Length - 1, 1));

            // MessageBox.Show();

            if (m.checkBox1.Checked != true)
            {

                m.checkBox1.Checked = true;

                ing_count++;
                main_price = main_price + price;

                this.food_price_lbl.Text = main_price.ToString() + "৳";



            }

            else
            {

                m.checkBox1.Checked = false;
                ing_count--;

                main_price = main_price - price;

                this.food_price_lbl.Text = main_price.ToString() + "৳";


            }




        }





















        private void Menu_infocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_infocs_Load(object sender, EventArgs e)
        {

        }

        private void plus_lbl_Click(object sender, EventArgs e)
        {
            counter++;
            quantity_lbl.Text = counter.ToString();
            food_price_lbl.Text = (counter * new_price).ToString() + "৳";
        }

        private void minus_lbl_Click(object sender, EventArgs e)
        {
            if (counter > 1)
            {

                counter--;
                quantity_lbl.Text = counter.ToString();
                food_price_lbl.Text = (counter * new_price).ToString() + "৳";


            }
        }

        private void add_to_ccart_button_Click(object sender, EventArgs e)
        {
            int res=fs.Insert_order(this.food_id, DateTime.Now, counter, main_price);
             MessageBox.Show("Your order is ready for cook");
            this.Hide();
        }
    }
}

