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
using System.Text.RegularExpressions;


namespace Ui_Layer.Fpc
{
    public partial class Setpass : UserControl
    {
        string patt = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        string email;
        ForgetServices fs;
        string username;
        
        public Setpass()
        {
            InitializeComponent();
            fs = new ForgetServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirm_pass_txb.Text) == true)
            {


                errorProvider1.SetError(this.confirm_pass_txb, "Enter new password");

            }



            else if (string.IsNullOrEmpty(confirm_pass_txb.Text) == true)
            {


                errorProvider2.SetError(this.confirm_pass_txb, "Enter new password");

            }


            else if (new_pas_txb.Text != confirm_pass_txb.Text) { errorProvider2.SetError(this.confirm_pass_txb, "Password not match"); }







            else {

                //database

                int result =fs.updateLogindata(email, user_name_txb.Text, confirm_pass_txb.Text);

                if (result > 0)
                {
                    MessageBox.Show("Password updated sucessfully");
                    groupBox1.Visible = false;
                    User_name_lbl.Text = string.Empty;
                    user_name_txb.Text = string.Empty;
                    new_pas_txb.Text = string.Empty;
                    confirm_pass_txb.Text = string.Empty;





                }


                else { MessageBox.Show(" information not updated"); }



            }
            
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirm_pass_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_pas_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_pas_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(new_pas_txb.Text) == true)
            {


                errorProvider1.SetError(this.new_pas_txb, "Enter new password");

            }

            else
            {

                errorProvider1.Clear();
            }
        }

        private void confirm_pass_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirm_pass_txb.Text) == true)
            {


                errorProvider2.SetError(this.confirm_pass_txb, "Enter new password");

            }


            else if (new_pas_txb.Text != confirm_pass_txb.Text) { errorProvider2.SetError(this.confirm_pass_txb, "Password not match"); }
            else
            {

                errorProvider2.Clear();
            }
        }

        private void Setpass_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void showpass_ck_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_ck.Checked)
            {

                new_pas_txb.UseSystemPasswordChar = false;
                confirm_pass_txb.UseSystemPasswordChar = false;

            }

            else {

                new_pas_txb.UseSystemPasswordChar = true;
                confirm_pass_txb.UseSystemPasswordChar = true;
            }
        }

        private void enter_email_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider3.SetError(this.textBox2, "Enter an email");

            }

            else if (Regex.IsMatch(textBox2.Text, patt) == false)
            {


                errorProvider3.SetError(this.textBox2, "Email is Not valid");
            }

            else {

                if (fs.Getusername(textBox2.Text) != null)
                {


                    LeadEmp le = fs.Getusername(textBox2.Text);
                    email = textBox2.Text;
                    username = le.Emp_username;
                    MessageBox.Show(username);
                   
                    textBox2.Text = string.Empty;

                    
                    User_name_lbl.Text = le.Emp_name;
                    user_name_txb.Text = le.Emp_username;
                    user_name_txb.Text.Trim();
                    groupBox1.Visible = true;
                }

                else
                {

                    MessageBox.Show("user not found");
                }


            }






        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider3.SetError(this.textBox2, "Enter an email");

            }

            else if (Regex.IsMatch(textBox2.Text, patt) == false)
            {


                errorProvider3.SetError(this.textBox2, "Email is Not valid");
            }

            else { errorProvider3.Clear(); }

        }

        private void user_name_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_name_txb.Text) == true)
            {
                
                errorProvider4.SetError(this.user_name_txb, "enter a user name");

            }
      

          else  if (username.Trim().ToLower()!=user_name_txb.Text.Trim().ToLower())
            {
              
                MessageBox.Show((username.Trim().ToLower() != user_name_txb.Text.Trim().ToLower()).ToString());
                if (fs.IseusernameAva(user_name_txb.Text) ==1)
                {

                    errorProvider4.SetError(this.user_name_txb, "username Already register");

                }
                else { errorProvider4.Clear(); }


            }

            else { errorProvider4.Clear(); }


        }
    }
}
