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
    public partial class Login : Form
    {
        public static User_ui_layer.User_ui ui;
        public static Forget_pass fp;
        public LoginServices ls;
        internal bool AdminAcess {  set
                {
                Program.ui.add_employee_btn.Visible = value;
                Program.ui.addemloyee1.Visible = value;
                 }

            }
        public Login()
        {
            InitializeComponent();
            ls = new LoginServices();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_name_txb.Text) == true)
            {
                errorProvider1.SetError(this.user_name_txb, "User name is emty");


            }


            else if (string.IsNullOrEmpty(pass_txb.Text) == true)
            {


                errorProvider1.SetError(this.pass_txb, "password is emty");


            }
            else
            {
               


                int result = ls.Login(user_name_txb.Text, pass_txb.Text);

                if (result == 1)
                {

                    this.Hide();
                    AdminAcess = true;

                    //Program.ui.add_employee_btn.Visible = true;
                    Program.ui.Show();


                }

                else if (result == 2)
                {


                    this.Hide();

                    // Program.ui.add_employee_btn.Visible = false;
                    AdminAcess = false;
                    Program.ui.Show();


                }

                else { MessageBox.Show("Invalid user"); }












                
                
            }
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fp = new Forget_pass();
           fp.Show();
        }

        private void user_name_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_name_txb.Text) == true)
            {
                errorProvider1.SetError(this.user_name_txb, "User name is emty");


            }
            else { errorProvider1.Clear(); }

        }

        private void pass_txb_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(pass_txb.Text) == true)
            {


                errorProvider1.SetError(this.pass_txb, "password is emty");


            }
            else
            {
                errorProvider1.Clear();
            }


        }
    }
}
