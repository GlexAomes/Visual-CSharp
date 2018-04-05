using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Platformer_Game
{
    public partial class Form1 : Form
    {
        Point ReSpawn;
        Point MenusMid = new Point(477, 619);
        bool Left;
        bool Right;
        bool SprintLeft;
        bool SprintRight;
        bool Jump;
        int Gravity = 15;
        int Velocityi;
        int Playing = 0;
        int CoinCount = 0;

        public Form1()
        {
            InitializeComponent();
            this.Height += 100;
            ReSpawn = pbPlayer.Location;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Boundry Collision
            if (pbPlayer.Right > pbRightWall.Left)
            {
                Right = false;
                SprintRight = false;
            }
            if (pbPlayer.Left < pbLeftWall.Right)
            {
                Left = false;
                SprintLeft = false;
            }
            //Spike contact
            if (pbPlayer.Right > pbSpike1.Left && pbPlayer.Right < pbSpike1.Right && pbPlayer.Bottom > pbSpike1.Top || pbPlayer.Left < pbSpike1.Right && pbPlayer.Left > pbSpike1.Left && pbPlayer.Bottom > pbSpike1.Top)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("You hit a spike! Start again?", "Gameover!", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    pbPlayer.Location = ReSpawn;
                    timer1.Start();
                    CoinCount = new int();
                    lblCoins1.Text = "Coins: 0";
                    //
                    pbCoin1.Visible = true;
                    //
                    //Reset movement
                    this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(x => x.FieldType == typeof(bool)).ToList().ForEach(f =>
                    {
                        f.SetValue(this, false);
                    });
                }
                else
                {
                    this.Close();
                }
            }

            if (pbPlayer.Right > pbCoin1.Left && pbPlayer.Right < pbCoin1.Right && pbPlayer.Bottom > pbCoin1.Top || pbPlayer.Left < pbCoin1.Right && pbPlayer.Left > pbCoin1.Left && pbPlayer.Bottom > pbCoin1.Top)
            {
                pbCoin1.Visible = false;
                CoinCount = +1;
                lblCoins1.Text = "Coins: " + CoinCount;
            }
            //Finish Collision
            if (pbPlayer.Right > pbFinish.Left && pbPlayer.Right < pbFinish.Right && pbPlayer.Bottom > pbFinish.Top || pbPlayer.Left < pbFinish.Right && pbPlayer.Left > pbFinish.Left && pbPlayer.Bottom > pbFinish.Top)
            {
                tbcGame.SelectedIndex = 4;
                Playing = 0;
                timer1.Stop();
                pbPlayer.Location = ReSpawn;
                CoinCount = new int();
                lblCoins1.Text = "Coins: 0";
                //
                pbCoin1.Visible = true;
                //
                //Reset movement
                this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(x => x.FieldType == typeof(bool)).ToList().ForEach(f =>
                {
                    f.SetValue(this, false);
                });
            }

            //L/R
            if (Left == true)
            {
                pbPlayer.Left -= 3;
            }
            if (SprintLeft == true)
            {
                pbPlayer.Left -= 6;
            }

            if (Right == true)
            {
                pbPlayer.Left += 3;
            }
            if (SprintRight == true)
            {
                pbPlayer.Left += 6;
            }

            //Jump
            if (Jump == true)
            {
                pbPlayer.Top -= Velocityi;
                Velocityi -= 1;
            }
            if (pbPlayer.Top + pbPlayer.Height >= pnlEnvironment.Height)
            {
                pbPlayer.Top = pnlEnvironment.Height - pbPlayer.Height;
                Jump = false;
            }
            else
            {
                pbPlayer.Top += 3;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right) //Start moving right
            {
                Right = true;
                SprintRight = false;

            }
            else if (e.KeyCode == Keys.Space && Right == true) //Start sprinting right
            {
                Right = false;
                SprintRight = true;

            }

            if (e.KeyCode == Keys.Left) //Start moving left
            {
                Left = true;
                SprintLeft = false;
            }
            else if (e.KeyCode == Keys.Space && Left == true) //Start sprinting left
            {
                //Left = false;
                SprintLeft = true;
            }

            //if (e.KeyCode == Keys.Escape) { this.Close(); } //Temp quick close

            if (Jump != true) //Check if not in air
            {
                if (e.KeyCode == Keys.Up) //Allow jump with up arrow
                {
                    Jump = true;
                    Velocityi = Gravity;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) //Stop moving right
            {
                Right = false;
                if (SprintRight == true) //Stop sprint right
                {
                    SprintRight = false;
                }
            }

            if (e.KeyCode == Keys.Left) //Stop moving left
            {
                Left = false;
                if (SprintLeft == true) //Stop sprint left
                {
                    SprintLeft = false;
                }
            }


            if (e.KeyCode == Keys.Space) //Stop sprinting
            {
                if (SprintRight == true) //Stop sprint right
                {
                    SprintRight = false;
                    Right = true;
                }
                if (SprintLeft == true) //Stop sprint left
                {
                    SprintLeft = false;
                    Left = true;
                }
            }
        }

        //
        //

        private void tbcGame_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (e.KeyCode == Keys.Right) //Start moving right
            {
                Right = true;
                SprintRight = false;
            }
            else if (e.KeyCode == Keys.Space && Right == true) //Start sprinting right
            {
                Right = false;
                SprintRight = true;
            }

            if (e.KeyCode == Keys.Left) //Start moving left
            {
                Left = true;
                SprintLeft = false;
            }
            else if (e.KeyCode == Keys.Space && Left == true) //Start sprinting left
            {
                //Left = false;
                SprintLeft = true;
            }

            if (e.KeyCode == Keys.Escape && Playing == 1) //Options or return
            {
                if (tbcGame.SelectedIndex == 1)
                {
                    tbcGame.SelectedIndex = 2;
                }
                else if (tbcGame.SelectedIndex == 2)
                {
                    tbcGame.SelectedIndex = 1;
                }
            }
            else if (e.KeyCode == Keys.Escape && Playing == 0)
            {
                if (tbcGame.SelectedIndex == 2)
                {
                    tbcGame.SelectedIndex = 0;
                }
            }



            if (Jump != true) //Check if not in air
            {
                if (e.KeyCode == Keys.Up) //Allow jump with up arrow
                {
                    Jump = true;
                    Velocityi = Gravity;
                }
            }
        }

        private void tbcGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) //Stop moving right
            {
                Right = false;
                if (SprintRight == true) //Stop sprint right
                {
                    SprintRight = false;
                }
            }

            if (e.KeyCode == Keys.Left) //Stop moving left
            {
                Left = false;
                if (SprintLeft == true) //Stop sprint left
                {
                    SprintLeft = false;
                }
            }


            if (e.KeyCode == Keys.Space) //Stop sprinting
            {
                if (SprintRight == true) //Stop sprint right
                {
                    SprintRight = false;
                    Right = true;
                }
                if (SprintLeft == true) //Stop sprint left
                {
                    SprintLeft = false;
                    Left = true;
                }
            }
        }

        private void tbcGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcGame.SelectedIndex != 1)
            {
                timer1.Stop();
            }
            else if (tbcGame.SelectedIndex == 1)
            {
                timer1.Start();
            }
        }

        #region menu
        private void btnPlay_Click(object sender, EventArgs e)
        {
            tbcGame.SelectedIndex = 1;
            Playing = 1;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            tbcGame.SelectedIndex = 3;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tbcGame.SelectedIndex = 1; //Go back to the game with a button
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            // Show the color dialog.

            DialogResult result = cldPlayer.ShowDialog();

            // See if user pressed ok.

            if (result == DialogResult.OK)
            {

                // Set form background to the selected color.

                pbPlayer.BackColor = cldPlayer.Color;

            }
        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About AboutBox1 = new About();
            AboutBox1.ShowDialog();
        }

        private void btnReturntoMenu_Click(object sender, EventArgs e)
        {
            if (Playing == 0)
            {
                tbcGame.SelectedIndex = 0;
            }
            else if (Playing == 1)
            {
                DialogResult result = MessageBox.Show("Your progress will not be saved!", "Return to Menu?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    pbPlayer.Location = ReSpawn;
                    timer1.Start();
                    CoinCount = new int();
                    lblCoins1.Text = "Coins: 0";
                    //
                    pbCoin1.Visible = true;
                    //
                    //Reset movement
                    this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(x => x.FieldType == typeof(bool)).ToList().ForEach(f =>
                    {
                        f.SetValue(this, false);
                    });
                    tbcGame.SelectedIndex = 0;
                    Playing = 0;
                }
            }
        }

        private void btnPlayerColorinOptions_Click(object sender, EventArgs e)
        {
            // Show the color dialog.

            DialogResult result = cldPlayer.ShowDialog();

            // See if user pressed ok.

            if (result == DialogResult.OK)
            {

                // Set form background to the selected color.

                pbPlayer.BackColor = cldPlayer.Color;
            }

        }

        private void btnAboutinOptions_Click(object sender, EventArgs e)
        {
            About AboutBox1 = new About();
            AboutBox1.ShowDialog();
        }

        private void btnReturntoMenufromOptions_Click(object sender, EventArgs e)
        {
            if (Playing == 0)
            {
                tbcGame.SelectedIndex = 0;
            }
        }

        private void btnQuitfromOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            tbcGame.SelectedIndex = 4;
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            tbcGame.SelectedIndex = 1;
            Playing = 1;
        }

        private void btnReturnfromLevels_Click(object sender, EventArgs e)
        {
            if (Playing == 0)
            {
                tbcGame.SelectedIndex = 0;
            }
        }
#endregion
        #region Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (timer1.Enabled == true || tbcGame.SelectedIndex == 0) //Simple Close in Menu
                {
                    e.Cancel = true;
                }
                if (timer1.Enabled == false && tbcGame.SelectedIndex == 2 || timer1.Enabled == false && tbcGame.SelectedIndex == 3) //Complex close trap in Game
                {
                    //Reset movement
                    this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(x => x.FieldType == typeof(bool)).ToList().ForEach(f =>
                    {
                        f.SetValue(this, false);
                    });
                    timer1.Start();
                    e.Cancel = true;
                }
            }
        }
        #endregion

    }
}
