using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui_Layer
{
    public partial class Two_player : UserControl
    {
        bool turn = true;
        int turn_count = 0;

        public Two_player()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // Two_player
            // 
            this.Name = "Two_player";
            this.Size = new System.Drawing.Size(230, 218);
            this.ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            winnercheck();
        }

        private void winnercheck()
        {
            bool there_is_a_winner = false;

            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                there_is_a_winner = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                there_is_a_winner = true;


            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                there_is_a_winner = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                there_is_a_winner = true;


            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disable_buttons();

                string winner = "";
                if (turn)
                {
                    winner = "Player 2";
                    p2_win_count.Text = (Int32.Parse(p2_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = "Player 1";
                    p1_win_count.Text = (Int32.Parse(p1_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins !", " Congratulations!");

            }
            else
            {
                if (turn_count == 9)
                {
                    Draw_count.Text = (Int32.Parse(Draw_count.Text) + 1).ToString();
                    MessageBox.Show(" DWAR !", " Oops!");

                }
            }
            
            

        }


        private void disable_buttons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {


        }

        private void againaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void againToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }   
            }
        }

        private void resetCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1_win_count.Text = "0";
            p2_win_count.Text = "0";
            Draw_count.Text = "0";
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }
            }
        }

        //private void InitializeComponent()
        //{
           

        //}
    }
}
