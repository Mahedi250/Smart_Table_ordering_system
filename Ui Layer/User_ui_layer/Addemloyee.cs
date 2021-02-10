using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Services;
using System.IO;



namespace Ui_Layer.User_ui_layer
{
    public partial class Addemloyee : UserControl
    {
        string patt = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        RegistrationServices rs;
        string loc;
        byte[] img;
        int index;
        public Addemloyee()
        {
            InitializeComponent();
            rs = new RegistrationServices();

            

        }

        

        public void Allclear() {

            full_name_txb.Text = Phone_txb.Text = email_txb.Text = address_txb.Text = user_name_txb.Text = pass_txb.Text = confirm_pass_txb.Text = string.Empty;

        } 

       

        private void tableLayoutPanel1_Leave(object sender, EventArgs e)
        {
            
        }

        private void full_name_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {

                e.Handled = false;
            }
            else if (ch == 8) { e.Handled = false; }
            else if (ch == 32) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void full_name_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(full_name_txb.Text) == true)
            {

               
                e1.SetError(this.full_name_txb, "Enter full name");



            }
            else {
                e1.Clear();

            }
        }

        private void gender_cmb_Leave(object sender, EventArgs e)
        {
            if (gender_cmb.SelectedItem == null)
            {

                e2.SetError(this.gender_cmb, "Please Select Gender");
            }

            else { e2.Clear(); }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Phone_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {

                e.Handled = false;
            }
            else if (ch == 8) { e.Handled = false; }
            
            else { e.Handled = true; }
        }

        private void Phone_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Phone_txb.Text) == true)
            {

              
                e3.SetError(this.Phone_txb, "Enter Vallid phone number");

            }
            else if(Phone_txb.Text.Length!=Phone_txb.MaxLength)
                    {

                e3.SetError(this.Phone_txb, "Enter valid phone number");
            }
            else
            {

                e3.Clear();
            }
        }

        private void email_txb_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(email_txb.Text) == true)
            {

                e4.SetError(this.email_txb, "Enter an email");

            }

            else if (Regex.IsMatch(email_txb.Text, patt) == false)
            {


                e4.SetError(this.email_txb, "Email is Not valid");
            }

            else if (rs.IsemailAva(email_txb.Text) == 1) {

                e4.SetError(this.email_txb, "Email is Allready registered");

            }

            else { e4.Clear(); }
        }

        private void user_type_txb_Leave(object sender, EventArgs e)
        {
            if (user_type_cmb.SelectedItem == null)
            {

                new ErrorProvider().SetError(this.user_type_cmb, "Please select userType");


            }

            else { e5.Clear();
                

            }

           
        }

        private void user_type_cmb_Click(object sender, EventArgs e)
        {
           
        }

       

        private void user_type_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {









        }

        private void user_type_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            
                
        }

        private void user_type_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            index = user_type_cmb.SelectedIndex;

            if (user_type_cmb.SelectedIndex==2)
            {


                groupBox1.Hide();

            }
            else
            {
                groupBox1.Show();
            }




        }

        private void user_name_txb_Leave(object sender, EventArgs e)
        {
            if (user_type_cmb.SelectedIndex != 2)
            {
                if (string.IsNullOrEmpty(user_name_txb.Text) == true)
                {


                    errorProvider3.SetError(this.user_name_txb, "Enter a Username");

                }

                else if (rs.IseusernameAva(user_name_txb.Text) == 1)
                {

                    errorProvider3.SetError(this.user_name_txb, "username is Allready registered");
                }
                else


                {

                    errorProvider3.Clear();
                }
            }
        }

        private void pass_txb_Leave(object sender, EventArgs e)
        {
            if (user_type_cmb.SelectedIndex !=2)
            {
                if (string.IsNullOrEmpty(pass_txb.Text) == true)
                {


                    errorProvider1.SetError(this.pass_txb, "Enter a password");

                }

                else
                {

                    errorProvider1.Clear();
                }

            }
        }

        private void confirm_pass_txb_Leave(object sender, EventArgs e)
        {
            if (user_type_cmb.SelectedIndex != 2)
            {
                if (string.IsNullOrEmpty(confirm_pass_txb.Text) == true)
                {


                    errorProvider2.SetError(this.confirm_pass_txb, "Enter Confirm password");

                }


                else if (pass_txb.Text != confirm_pass_txb.Text) { errorProvider2.SetError(this.confirm_pass_txb, "Password not match"); }
                else
                {

                    errorProvider2.Clear();
                }
            }
           
        }

       

       

        private void user_name_txb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)       //Submit button
        {
            

            if (string.IsNullOrEmpty(full_name_txb.Text) == true)
            {


                e1.SetError(this.full_name_txb, "Enter full name");



            }

            else if (gender_cmb.SelectedItem == null)
            {

                e2.SetError(this.gender_cmb, "Please Select Gender");
            }

            else if (string.IsNullOrEmpty(Phone_txb.Text) == true)
            {


                e3.SetError(this.Phone_txb, "Enter Vallid phone number");

            }
            else if (Phone_txb.Text.Length != Phone_txb.MaxLength)
            {

                e3.SetError(this.Phone_txb, "Enter valid phone number");
            }

            else if (string.IsNullOrEmpty(email_txb.Text) == true)
            {

                e4.SetError(this.email_txb, "Enter an email");

            }

            else if (Regex.IsMatch(email_txb.Text, patt) == false)
            {


                e4.SetError(this.email_txb, "Email is Not valid");
            }
            else if (rs.IsemailAva(email_txb.Text) == 1)
            {

                e4.SetError(this.email_txb, "Email is Allready registered");

            }

            else if (string.IsNullOrEmpty(address_txb.Text) == true)
            {


                errorProvider4.SetError(this.address_txb, "address is emty");

            }




            else if (user_type_cmb.SelectedItem == null)
            {

                e10.SetError(this.user_type_cmb, "Please Select usertype");
            }



            else if (user_type_cmb.SelectedIndex != 2 && string.IsNullOrEmpty(user_name_txb.Text) == true)
            {


                errorProvider3.SetError(this.user_name_txb, "Enter a Username");

            }

            else if (user_type_cmb.SelectedIndex != 2 && string.IsNullOrEmpty(pass_txb.Text) == true)
            {


                errorProvider1.SetError(this.pass_txb, "Enter a password");

            }



            else if (user_type_cmb.SelectedIndex != 2 && string.IsNullOrEmpty(confirm_pass_txb.Text) == true)
            {


                errorProvider2.SetError(this.confirm_pass_txb, "Enter Confirm password");


            }
            else if (user_type_cmb.SelectedIndex != 2 && pass_txb.Text != confirm_pass_txb.Text)
            {
                errorProvider2.SetError(this.confirm_pass_txb, "Password not match");
            }

            else if (pictureBox1.ImageLocation == null) {


                errorProvider6.SetError(this.pictureBox1, "Add a Photo");



            }

            //End of valiidation








            else
            {
                errorProvider6.Clear();


                if (user_type_cmb.SelectedIndex != 2)
                {


                    int result= rs.LeadRegistration(full_name_txb.Text, gender_cmb.Text, dateTimePicker1.Value, Phone_txb.Text, email_txb.Text, address_txb.Text,index, img, user_name_txb.Text, pass_txb.Text);


                    if (result==3)
                    {
                        MessageBox.Show("User Inserted succesfully ");
                        //services Here

                        
                    }
                    else { MessageBox.Show("User not Inserted succesfully "); }


                }
                else {

                 int result=   rs.ChefRegistration(full_name_txb.Text, gender_cmb.Text, dateTimePicker1.Value, Phone_txb.Text, email_txb.Text, address_txb.Text,index, img);
                    if (result==1)
                    {
                        MessageBox.Show("User Inserted succesfully ");
                        //services Here


                    }
                    else { MessageBox.Show("User not Inserted succesfully "); }


                }

               

                Allclear();










            }














            }

        private void address_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address_txb.Text) == true)
            {


              errorProvider4.SetError(this.address_txb, "address is emty");

            }
            else
            {

             errorProvider4.Clear();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_type_cmb_Leave(object sender, EventArgs e)
        {
            if (user_type_cmb.SelectedItem == null)
            {

               e10.SetError(this.user_type_cmb, "Please Select usertype");
            }

            else { e10.Clear(); }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                if (open.ShowDialog() == DialogResult.OK)
                {
                     loc= open.FileName.ToString();
                    pictureBox1.ImageLocation = loc;

                    try
                    {
                         img = null;
                        FileStream fs = new FileStream(loc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);



                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
