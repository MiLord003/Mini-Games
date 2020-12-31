using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_car_games
{
    public partial class Form4 : Form
    {

        bool jumping = false;
        int pipespeed = 5;
        int gravity = 5;
        int inscore = 0;


        public Form4()
        {
            InitializeComponent();
            endGame1.Text = "Game Over";
            endGame2.Text = "Press Enter to Restart";
            endGame1.Visible = false;
            endGame2.Visible = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            flappybird.Top += gravity;
            scoreText.Text = "" + inscore;

            if (pipebottom.Left < -80)
            {
                pipebottom.Left = 1000;
                inscore += 1;
            }

            else if (pipetop.Left < -95)
            {
                pipetop.Left = 1100;
                inscore += 1;
            }

            if (flappybird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            else if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds))
            {
                endGame();
            }

            else if (flappybird.Bounds.IntersectsWith(pipetop.Bounds))
            {
                endGame();
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = -5;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endGame1.Visible = true;
            endGame2.Visible = true;
            
        }


    }
}
