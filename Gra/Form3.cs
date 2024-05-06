using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form3 : Form
    {
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public Queue<int> activeBoxes = new Queue<int>();
        public int seconds = 0;
        public int speed;
        public int speed2;
        public int total = 0;
        public int score = 0;
        public int life = 4;

        public Form3()
        {
            InitializeComponent();
            MakeBoard();
        }

        private void MakeBoard()
        {
            pictureBoxes.Add(pictureBox1); pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3); pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5); pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7); pictureBoxes.Add(pictureBox8);

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Click += Box_Click;
            }
        }

        private void Game_timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = seconds--.ToString();
            scoreLabel.Text = score.ToString();
            lifeLabel.Text = life.ToString();
            if (seconds < 0)
            {
                game_timer.Stop();
                MessageBox.Show("Score: " + score, "Game Over");
                this.Close();
            }
            if (life==0)
            {
                game_timer.Stop();
                MessageBox.Show("Score: " + score, "Game Over");
                this.Close();
            }
            Renew();
        }

        private void Renew()
        {
            if (seconds == 300)
            {
                speed = 7;
                speed2 = 5;
            }
            //renewal
            if (seconds % speed == 0)
                GenerateDydelf();
            if (seconds % speed2 == 0)
            {
                if (activeBoxes.Count != 0)
                {
                    PictureBox pictureBox = pictureBoxes.ElementAtOrDefault(activeBoxes.Dequeue());
                    pictureBox.Visible = false;
                }
                else
                {
                    foreach (PictureBox pictureBox in pictureBoxes)
                    {
                        pictureBox.Visible = false;
                    }
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            seconds = 600;
            score = 0;
            speed = 8;
            speed2 = 10;
            life = 4;
            game_timer.Start();
            GenerateDydelf();
        }

        public void GenerateDydelf()
        {
            Random rand = new Random();
            int index = rand.Next(pictureBoxes.Count);
            activeBoxes.Enqueue(index);
            PictureBox pictureBox = pictureBoxes.ElementAtOrDefault(index);
            if (pictureBox != null)
            {
                if (pictureBox.Visible == false)
                {
                    pictureBox.Visible = true;
                    total++;
                    life = score - total + 1 + 4;
                }
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            if (box.Visible)
            {
                box.Visible = false;
                score++;
            }
        }

        private void dissapearance_timer_Tick(object sender, EventArgs e)
        {


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
