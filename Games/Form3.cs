using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_car_games
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            over.Visible = false;
            restart.Visible = false;
        }

        Random r = new Random();
        Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.DarkOrange };
        int score = 0;

        void movebar(PictureBox bars)
        {
            if (bars.Top <= this.Height)
            { bars.Top += 4; }
            else
            {
                bars.Top = 0;
                bars.BackColor = colors[r.Next(colors.Length)];
            }
        }

        void gameover(PictureBox bar)
        {
            if (bar.Bounds.IntersectsWith(player.Bounds)) 
            {
                if (bar.BackColor != player.BackColor) 
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                    restart.Visible = true;
                }
                else
                {
                    score++;
                    points.Text = score.ToString();
                }
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left >= 0)
                    player.Left += -20;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Right <= (this.Width - 20))
                    player.Left += 20;
            }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) 
                {
                    player.BackColor = colors[r.Next(colors.Length)];
                }

            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movebar(bar1);
            movebar(bar2);
            movebar(bar3);
            gameover(bar1);
            gameover(bar2);
            gameover(bar3);
        }
    }
}

