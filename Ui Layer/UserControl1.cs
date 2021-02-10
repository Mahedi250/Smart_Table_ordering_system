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

namespace Ui_Layer
{
    public partial class add_ing : UserControl
    {
        Food_services fs;
        public add_ing()
        {
            InitializeComponent();
            fs = new Food_services();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  index = cat_id_ing_cmb.SelectedIndex + 1;
            float price = float.Parse(ing_price.Text);
           int res= fs.Adding_ingradians(ing_name_txb.Text, price, index);
            if (res > 0) { MessageBox.Show("Added"); }
            
            else { MessageBox.Show("failed"); }
            ing_name_txb.Text = ing_price.Text = string.Empty;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.food_catTableAdapter.FillBy(this.tOSDataSet3.Food_cat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
