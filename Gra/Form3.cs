using Gra.Properties;
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
        public List<PictureBox> activeBoxes = new List<PictureBox>();
        public int seconds = 0;
        public int speed;
        public int speed2;
        public int speed3;
        public int speed4;
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
                pictureBox.Image = Resources.dydelf;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            if (life == 0)
            {
                game_timer.Stop();
                MessageBox.Show("Score: " + score, "Game Over");
                this.Close();
            }
            Renew();
        }

        private void Renew()
        {

            //renewal
            if (seconds % speed == 0)
                GenerateDydelf();
            if (seconds % speed2 == 0)
            {
                if (activeBoxes.Count != 0)
                {
                    PictureBox pictureBox = activeBoxes[0];
                    pictureBox.Visible = false;
                    life--;
                }
                else
                {
                    foreach (PictureBox pictureBox in pictureBoxes)
                    {
                        pictureBox.Visible = false;
                    }
                }
            }

            //drugi zwierzak lepiej punktowany
            if (seconds % speed3 == 0)
                GenerateLemur();
            if (seconds % speed4 == 0)
            {
                if (activeBoxes.Count != 0)
                {
                    PictureBox pictureBox = activeBoxes[0];
                    pictureBox.Visible = false;
                    life--;
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
            speed2 = 12;
            speed3 = 14;
            speed4 = 15;
            life = 4;
            game_timer.Start();
            dissapearance_timer.Start();
            GenerateDydelf();
        }

        public void GenerateDydelf()
        {
            Random rand = new Random();
            int index = rand.Next(pictureBoxes.Count);
            PictureBox pictureBox = pictureBoxes.ElementAtOrDefault(index);
            activeBoxes.Add(pictureBox);
            if (pictureBox != null)
            {
                if (pictureBox.Visible == false)
                {
                    pictureBox.Image = Resources.dydelf;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = "dydelf";
                    pictureBox.Visible = true;
                    total++;

                }
            }
        }

        public void GenerateLemur()
        {
            Random rand = new Random();
            int index = rand.Next(pictureBoxes.Count);
            PictureBox pictureBox = pictureBoxes.ElementAtOrDefault(index);
            activeBoxes.Add(pictureBox);
            if (pictureBox != null)
            {
                if (pictureBox.Visible == false)
                {
                    pictureBox.Image = Resources.lemur;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = "lemur";
                    pictureBox.Visible = true;
                    total++;

                }
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            activeBoxes.Remove(box);
            if (box.Visible)
            {
                box.Visible = false;

                // Porównywanie za pomocą tagów
                if (box.Tag != null && box.Tag.ToString() == "lemur")
                {
                    score += 3;
                }
                else if (box.Tag != null && box.Tag.ToString() == "dydelf")
                {
                    score++;
                }
                else
                {
                    score++;
                }
            }
        }


        private void dissapearance_timer_Tick(object sender, EventArgs e)
        {
            

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lifeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
