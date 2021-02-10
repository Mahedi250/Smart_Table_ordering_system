using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Services;



namespace Ui_Layer.Fpc
{
    public partial class Confirmation : UserControl
    {
        string patt = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        string randomnumber;
        ForgetServices fs;
        public Confirmation()
        {
            InitializeComponent();
            fs = new ForgetServices();
        }

        public void Visblec(bool x) {//verify visibility

            vc_label.Visible = x;
            confirm_txb.Visible = x;
            confirm_btn.Visible = x;

        } 

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if (string.IsNullOrEmpty(email_id_txb.Text) == true)
            {
                email_id_txb.Focus();
                e4.SetError(this.email_id_txb, "Enter an email");

            }

            else if (Regex.IsMatch(email_id_txb.Text, patt) == false)
            {


                e4.SetError(this.email_id_txb, "Email is Not valid");
            }


            else
            {



                if (fs.GetAdminemal(email_id_txb.Text) == 1)
                {



                    Random x = new Random();
                    randomnumber = (x.Next(10000, 99999)).ToString();
                    MailMessage mm = new MailMessage("maruf250@gmail.com", email_id_txb.Text);
                    mm.Subject = "Password recover ";
                    mm.Body = "Your verification code is :" + randomnumber;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;

                    System.Net.NetworkCredential nc = new NetworkCredential("maruf250@gmail.com", "maruf44385");

                    smtp.Credentials = nc;
                    smtp.EnableSsl = true;
                    try
                    {
                        smtp.Send(mm);

                        MessageBox.Show("An varification code is sent to" + " " + email_id_txb.Text);
                        email_id_txb.Text = string.Empty;

                        Visblec(true);
                    }
                    catch(Exception g) { MessageBox.Show(g.Message); }
                

                }

                else { MessageBox.Show("You dont Have the privilage!! Contact to admin");
                    email_id_txb.Text = string.Empty;
                    Visblec(false);
                }
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
             if (confirm_txb.Text == randomnumber)
             {

                 confirm_txb.Text = string.Empty;
                 MessageBox.Show("Ready for Reseting Password");
                 this.Hide();


             }
             else { MessageBox.Show("Wrong Varification"); }

          
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            email_id_txb.Focus();
        }

        private void email_id_txb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_id_txb.Text) == true)
            {
                email_id_txb.Focus();
                e4.SetError(this.email_id_txb, "Enter an email");

            }

            else if (Regex.IsMatch(email_id_txb.Text, patt) == false)
            {


                e4.SetError(this.email_id_txb, "Email is Not valid");
            }

            else { e4.Clear(); }
        }
    }
}
