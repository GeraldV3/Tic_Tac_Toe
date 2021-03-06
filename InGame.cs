using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Tic_Tac_Toe
{
    public partial class InGame : Form
    {
        Form opener;
        SoundPlayer InGameTheme = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\LobbyTheme.wav");
        SoundPlayer ButtonSound = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\ButtonSound.wav");
        bool flip = true;
        int counter = 0;
        public InGame()
        {
            InitializeComponent();
            opener = new Form();
            //1st Layer
            Button Turn = (BTN_1);
            LBL_1.Visible = false;
            BTN_1.Enabled = true;
  

            Button Turn2 = (BTN_2);
            LBL_2.Visible = false;
            BTN_2.Enabled = true;

            Button Turn3 = (BTN_3);
            LBL_3.Visible = false;
            BTN_3.Enabled = true;

            //2nd Layer
            Button Turn4 = (BTN_4);
            LBL_4.Visible = false;
            BTN_4.Enabled = true;

            Button Turn5 = (BTN_5);
            LBL_5.Visible = false;
            BTN_5.Enabled = true;

            Button Turn6 = (BTN_6);
            LBL_6.Visible = false;
            BTN_6.Enabled = true;

            //3rd Layer
            Button Turn7 = (BTN_4);
            LBL_7.Visible = false;
            BTN_7.Enabled = true;

            Button Turn8 = (BTN_8);
            LBL_8.Visible = false;
            BTN_8.Enabled = true;

            Button Turn9 = (BTN_9);
            LBL_9.Visible = false;
            BTN_9.Enabled = true;
        }
        private void BTN_1_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_1.Visible = true;
            Button Turn = (Button)sender;
            if (flip)
                LBL_1.Text = "X";
            else
                LBL_1.Text = "O";
            flip = !flip;
            Turn.Enabled = false;
            BTN_1.Visible = false;
        }
        private void BTN_2_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_2.Visible = true;
            Button Turn2 = (Button)sender;
            if (flip)
                LBL_2.Text = "X";
            else
                LBL_2.Text = "O";
            flip = !flip;
            Turn2.Enabled = false;
            BTN_2.Visible = false;
        }
        private void BTN_3_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_3.Visible = true;
            Button Turn3 = (Button)sender;
            if (flip)
                LBL_3.Text = "X";
            else
                LBL_3.Text = "O";
            flip = !flip;
            Turn3.Enabled = false;
            BTN_3.Visible = false;
        }
        private void BTN_4_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_4.Visible = true;
            Button Turn4 = (Button)sender;
            if (flip)
                LBL_4.Text = "X";
            else
                LBL_4.Text = "O";
            flip = !flip;
            Turn4.Enabled = false;
            BTN_4.Visible = false;
        }
        private void BTN_5_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_5.Visible = true;
            Button Turn5 = (Button)sender;
            if (flip)
                LBL_5.Text = "X";
            else
                LBL_5.Text = "O";
            flip = !flip;
            Turn5.Enabled = false;
            BTN_5.Visible = false;
        }
        private void BTN_6_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_6.Visible = true;
            Button Turn6 = (Button)sender;
            if (flip)
                LBL_6.Text = "X";
            else
                LBL_6.Text = "O";
            flip = !flip;
            Turn6.Enabled = false;
            BTN_6.Visible = false;
        }
        private void BTN_7_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_7.Visible = true;
            Button Turn7 = (Button)sender;
            if (flip)
                LBL_7.Text = "X";
            else
                LBL_5.Text = "O";
            flip = !flip;
            Turn7.Enabled = false;
            BTN_7.Visible = false;
        }
        private void BTN_8_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_8.Visible = true;
            Button Turn8 = (Button)sender;
            if (flip)
                LBL_8.Text = "X";
            else
                LBL_8.Text = "O";
            flip = !flip;
            Turn8.Enabled = false;
            BTN_8.Visible = false;
        }
        private void BTN_9_Click(object sender, EventArgs e)
        {
            ButtonSound.Play();
            LBL_9.Visible = true;
            Button Turn9 = (Button)sender;
            if (flip)
                LBL_9.Text = "X";
            else
                LBL_9.Text = "O";
            flip = !flip;
            Turn9.Enabled = false;
            BTN_9.Visible = false;
        }
        private void Home_btn_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }
        private void LBL_1_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text) && (!LBL_1.Enabled))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text) && (!LBL_4.Enabled))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text) && (!LBL_7.Enabled))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text) && (!LBL_1.Enabled))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text) && (!LBL_2.Enabled))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text) && (!LBL_3.Enabled))
                win = true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


            if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)

            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
            }
        }
        private void LBL_2_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text) && (!LBL_1.Enabled))
                win = true;
            else if((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text) && (!LBL_2.Enabled))
                win = true;
            else if((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text) && (!LBL_3.Enabled))
                win = true;

            // Cross Line
            else if((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


            if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_3_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text) && (!LBL_1.Enabled))
                win = true;
            else if((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text) && (!LBL_2.Enabled))
                win = true;
            else if((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text) && (!LBL_3.Enabled))
                win = true;

            // Cross Line
            else if((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


            if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_4_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text) && (!LBL_1.Enabled))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text) && (!LBL_4.Enabled))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text) && (!LBL_7.Enabled))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win= true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


            if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_5_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win= true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


                if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_6_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win= true;

                // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                    win = true;
            if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


            if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_7_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text) && (!LBL_1.Enabled))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text) && (!LBL_4.Enabled))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text) && (!LBL_7.Enabled))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win = true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


                if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_8_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win= true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


                if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void LBL_9_MouseHover(object sender, EventArgs e)
        {
            // Straight Line
            bool win = false;
            if ((LBL_1.Text == LBL_2.Text) && (LBL_2.Text == LBL_3.Text))
                win = true;
            else if ((LBL_4.Text == LBL_5.Text) && (LBL_5.Text == LBL_6.Text))
                win = true;
            else if ((LBL_7.Text == LBL_8.Text) && (LBL_8.Text == LBL_9.Text))
                win = true;

            // Standing Line
            else if ((LBL_1.Text == LBL_4.Text) && (LBL_4.Text == LBL_7.Text))
                win = true;
            else if ((LBL_2.Text == LBL_5.Text) && (LBL_5.Text == LBL_8.Text))
                win = true;
            else if ((LBL_3.Text == LBL_6.Text) && (LBL_6.Text == LBL_9.Text))
                win = true;

            // Cross Line
            else if ((LBL_1.Text == LBL_5.Text) && (LBL_5.Text == LBL_9.Text))
                win = true;
            else if ((LBL_3.Text == LBL_5.Text) && (LBL_5.Text == LBL_7.Text))
                win = true;


                if (win)
            {
                String winner = "";
                if (flip)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Player " + winner + " Wins 100 Pesos");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("It`s a Draw");
                LBL_1.Text = "";
                LBL_2.Text = "";
                LBL_3.Text = "";
                LBL_4.Text = "";
                LBL_5.Text = "";
                LBL_6.Text = "";
                LBL_7.Text = "";
                LBL_8.Text = "";
                LBL_9.Text = "";
                counter = 0;
                BTN_1.Enabled = false;
                BTN_2.Enabled = false;
                BTN_3.Enabled = false;
                BTN_4.Enabled = false;
                BTN_5.Enabled = false;
                BTN_6.Enabled = false;
                BTN_7.Enabled = false;
                BTN_8.Enabled = false;
                BTN_9.Enabled = false;
            }
        }
        private void InGame_Load(object sender, EventArgs e)
        {
            InGameTheme.Play();
        }
        private void Retry_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
