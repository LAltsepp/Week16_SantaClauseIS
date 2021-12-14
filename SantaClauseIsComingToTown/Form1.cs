using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SantaClauseIsComingToTown
{
    public partial class Form1 : Form
    {

        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        int backroundSpeed = 3;



        public Form1()
        {
            InitializeComponent();
        }

        private void santa_Click(object sender, EventArgs e)
        {

        }

        private void tree_Click(object sender, EventArgs e)
        {

        }

        private void snowflake_Click(object sender, EventArgs e)
        {

        }

        private void moon_Click(object sender, EventArgs e)
        {

        }

        private void hut_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sleigh.Top += gravity;
            snowflake.Left -= pipeSpeed;
            tree.Left -= pipeSpeed;
            moon.Left -= backroundSpeed;
            hut.Left -= backroundSpeed;
            Score.Text = $"score: {score}";

            if (snowflake.Left < -100)
            {
                snowflake.Left = 1000;
            }
            if (tree.Left < -100)
            {
                tree.Left = 900;
                score++;
            }
            if (moon.Left < -100)
            {
                moon.Left = 800;
            }
            if (hut.Left < -100)
            {
                hut.Left = 900;
            }
            if (sleigh.Top < -25)
            {
                gameOver();
            }
            if (sleigh.Bounds.IntersectsWith(snowflake.Bounds) || sleigh.Bounds.IntersectsWith(tree.Bounds) || sleigh.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            Score.Text = $"Game Over";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
