using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui_Layer.User_controll;
using Services;

namespace Ui_Layer.User_ui_layer
{
   
    public partial class User_menu : UserControl
    {
        Add_food af;
        Food_services fs;
        int id_for_update=0;
        Add_food uaf;
        int avl;
        public User_menu()
        {
            InitializeComponent();
            af = new Add_food();
            fs = new Food_services();
            Loadall();




        }

        private void add_iten_btn_Click(object sender, EventArgs e)
        {
            af.ShowDialog();
        }

        private void User_menu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fs.Get_menu();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            dataGridView1.RowTemplate.Height = 60;

        }

        private void update_item_btn_Click(object sender, EventArgs e)
        {
            if (id_for_update != 0)
            {
                uaf = new Add_food(id_for_update);
                uaf.ShowDialog();
            }
            else { MessageBox.Show("Please click Food Id For update"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_for_update = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            avl = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            MessageBox.Show(id_for_update.ToString()+" Selected");
           

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fs.Get_menu();
           
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            dataGridView1.RowTemplate.Height = 60;
        }

        private void remove_item_btn_Click(object sender, EventArgs e)
        {
            if (id_for_update != 0)
            {
                fs.Rremove_Item(id_for_update);
                Loadall();
            }
            else { MessageBox.Show("Please click Food Id For update"); }
           

        }


        public void Loadall() {

            dataGridView1.DataSource = fs.Get_menu();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            dataGridView1.RowTemplate.Height = 60;




        }

        private void add_sold_out_btn_Click(object sender, EventArgs e)
        {
            if (id_for_update != 0)
            {
                if (avl == 1)
                {
                    fs.Set_ava(id_for_update, 0);
                    MessageBox.Show("SOLD-OUT TAG ADDED!!");

                }
                else
                {
                    fs.Set_ava(id_for_update, 1);
                    MessageBox.Show("ITEM IS SET to AVAILABLE!!");
                }
                Loadall();
            }
            else { MessageBox.Show("Please click Food Id For Seting AVAILABLITY status"); }

           
           
        }
    }
}
