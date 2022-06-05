using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeTop.Left -= pipeSpeed;
            BotomPipe.Left -= pipeSpeed;
            ScoreText.Text = "Score" + score;

            if (PipeTop.Left < -150)
            {
                PipeTop.Left = 800;
                score++;

            }
            if (BotomPipe.Left < -180)
            {
                BotomPipe.Left = 700;
                score++;
            }
            if(FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds)||
                FlappyBird.Bounds.IntersectsWith(BotomPipe.Bounds)||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds))
            {
                endGame();
            }
            if (score >= 5){
                pipeSpeed = 15; 
            }
            if (FlappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamkeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }

        }
        private void endGame()
        {
            GameTime.Stop();
            ScoreText.Text += "Game Over Biro";
        }
    }
}
