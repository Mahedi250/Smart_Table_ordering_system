using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Services;
using System.Data.Linq;
using Entities;



namespace Ui_Layer
{
    
    public partial class Add_food : Form
    {
       
        OpenFileDialog open;
        Food_services fs;
        int index;
        DataGridViewCheckBoxColumn chkbox;
        int food_cata;
        int id_for_update;
        string filename;
        string prev_name;
        int flag = 0;
        string savefile;
       
        


        public Add_food()
        {
            InitializeComponent();
            fs = new Food_services();
            add_ing1.Visible = false;
            chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "chkcolum";
            submit_btn.BringToFront();

        }
        public Add_food(int id)
        {
            InitializeComponent();
            fs = new Food_services();
            add_ing1.Visible = false;
            chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "chkcolum";
            id_for_update = id;
            Getalldata_for_update(id_for_update);
            Update_btn.BringToFront();
            open=new OpenFileDialog();




        }


        public void Getalldata_for_update(int id) {

            Entities.Menu menu = new Entities.Menu();
             var id_list= new List <Ing>();


           menu= fs.Get_data_for_update(id);
            id_list = fs.Get_ingid(id);


            if (menu != null)
            {

                food_name_txb.Text = menu.Food_Name;
                food_price_txb.Text = menu.Food_Price.ToString();
                food_details_txb.Text = menu.Food_Details;
                food_cooking_txb.Text = menu.Food_COOking_time.ToString();
                
               
                food_pic.Image = menu.Food_photo;
                prev_name = menu.Food_path;

                
                


                this.Load += new EventHandler((object o, EventArgs s) =>
                {

                    int x = menu.Food_cata;
                   
                    food_cat_cmb.SelectedIndex = x - 1;


                    dataGridView1.DataSource = fs.Get_ingrdiant(food_cat_cmb.SelectedIndex+1);

                    if (dataGridView1.Columns.Contains("chkcolum") != true)
                    { dataGridView1.Columns.Insert(0, chkbox); }


                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        int rowvalue = Convert.ToInt32(dr.Cells["ing_id"].Value);
                        for (int i = 0; i < id_list.Count; i++)
                        {

                            if (rowvalue == id_list[i].Ing_id)
                            {


                                dr.Cells["chkcolum"].Value = true;


                            }


                        }
                    }


                });

                   


                    }
            
                
            else MessageBox.Show("Menu not found");



        }
       




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_food_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            int new_fId = 0;
            new_fId = fs.Get_food_id()+1;
            int y = Convert.ToInt16(food_cooking_txb.Text);
            float price = float.Parse(food_price_txb.Text);
            index = food_cat_cmb.SelectedIndex + 1;


            if (open.CheckFileExists)
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 18));
                string CorrectFilename = DateTime.Now.ToString("yyyy_MM_dd_mm_ss") + System.IO.Path.GetFileName(open.FileName);
                string savefile = path + "\\resource\\" + CorrectFilename;
                int rs = fs.Add_new_menu(food_name_txb.Text, price, food_details_txb.Text, y, savefile, 1, index);
                
                


                File.Copy(open.FileName, path + "\\resource\\" + CorrectFilename);



                if (rs > 0) MessageBox.Show("Food Added sucessfully");


            

            }
            else MessageBox.Show("unsucessfull");



            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                bool selected = Convert.ToBoolean(dr.Cells["chkcolum"].Value);

                if (selected) {

                    int in_id = Convert.ToInt32(dr.Cells[1].Value);

                    fs.adding_extra_ing(new_fId,in_id);

                }
              

          
            }

        
           
        }

        private void Add_food_Load(object sender, EventArgs e)
        {
           
            
            // TODO: This line of code loads data into the 'tOSDataSet2.Ads_on_ing' table. You can move, or remove it, as needed.
            this.ads_on_ingTableAdapter.Fill(this.tOSDataSet2.Ads_on_ing);
            // TODO: This line of code loads data into the 'tOSDataSet1.Food_cat' table. You can move, or remove it, as needed.
            this.food_catTableAdapter1.Fill(this.tOSDataSet1.Food_cat);


        }

        private void photo_bro_btn_Click(object sender, EventArgs e)
        {
           
               // open file dialog   
                 open = new OpenFileDialog();
                open.InitialDirectory = "c:\\";

                // image filters  

              open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                open.FilterIndex = 1; 
                if (open.ShowDialog() == DialogResult.OK)
                {
                flag = 1;
                
                filename = open.FileName;

                Image img = Image.FromFile(filename);
                food_pic.Image = img;





            }
            // string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 18));
            //MessageBox.Show(path);


        }

        private void food_cooking_txb_TextChanged(object sender, EventArgs e)
        {

        }
        private void food_cat_cmb_indexChange(object sender, EventArgs e) {






        }

        private void food_cat_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             food_cata = Convert.ToInt32(food_cat_cmb.SelectedIndex + 1);

       




            dataGridView1.DataSource = fs.Get_ingrdiant(food_cata);

            if (dataGridView1.Columns.Contains("chkcolum") != true)
            { dataGridView1.Columns.Insert(0, chkbox); }



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "Hide")
            {

                add_ing1.Visible = true;
                button1.Text = "Hide";
             dataGridView1.DataSource=fs.Get_ingrdiant(food_cata);

            }
            else {

                add_ing1.Visible = false;
                button1.Text = "ADD";
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int r2=0;
            int y = Convert.ToInt16(food_cooking_txb.Text);
            float price = float.Parse(food_price_txb.Text);
            index = food_cat_cmb.SelectedIndex + 1;


            if (open.CheckFileExists)
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 18));
                string CorrectFilename = DateTime.Now.ToString("yyyy_MM_dd_mm_ss") + System.IO.Path.GetFileName(open.FileName);
                if (flag != 0)
                {
                    savefile = path + "\\resource\\" + CorrectFilename;


                }
                else { savefile =  prev_name; }
               
                int rs = fs.Replace_menu(food_name_txb.Text, price, food_details_txb.Text, y, savefile, 1, index, id_for_update);




                if (fs.Is_food_extra(id_for_update) != 0)
                {

                    r2 = fs.Remove_pre_ing(id_for_update);




                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        bool selected = Convert.ToBoolean(dr.Cells["chkcolum"].Value);

                        if (selected)
                        {

                            int in_id = Convert.ToInt32(dr.Cells[1].Value);

                            fs.adding_extra_ing(id_for_update, in_id);

                        }



                    }



                }


                

                

                else {


                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        bool selected = Convert.ToBoolean(dr.Cells["chkcolum"].Value);

                        if (selected)
                        {

                            int in_id = Convert.ToInt32(dr.Cells[1].Value);

                            fs.adding_extra_ing(id_for_update, in_id);

                        }



                    }




                }






                if (flag != 0)
                {
                    File.Copy(open.FileName, path + "\\resource\\" + CorrectFilename);


                }

              

                    


                
             

                if (rs > 0) MessageBox.Show("Food updated sucessfully");
                else MessageBox.Show("unsucessfull");

            }
        }   }
}  
