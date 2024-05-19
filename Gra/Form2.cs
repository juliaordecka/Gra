using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Gra
{
    public partial class Form2 : Form
    {
        Form1 parent;
        bool allowClick = false;
        Random rnd = new Random();
        PictureBox firstGuess;
        PictureBox secondGuess;
        PictureBox thirdGuess;
        Timer clickTimer = new Timer();
        Timer specialTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        PictureBox specialPictureBox;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            specialPictureBox = new PictureBox();

        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Click += clickImage;
            }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources._1,
                    Properties.Resources._2,
                    Properties.Resources._3,
                    Properties.Resources._4,
                    Properties.Resources._5
                };
            }
        }

        private void startGameTimer()
        {
            
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time == 0)
                {
                    timer.Stop();
                    clickTimer.Stop();
                    specialTimer.Stop();
                    MessageBox.Show("Koniec czasu");
                    parent.SCORE = 0;
                    parent.RODZAJ = "Memory";
                    parent.Zapis_do_CSV();
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                czasm.Text = "Czas: " + ssTime.ToString("ss");
            };
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
                
            }
            setRandomImages();
            HideImages();
            
            time = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.x;
            }
            specialPictureBox.Image = Properties.Resources.x;
        }

        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach (var img in images)
            {
                getFreeSlot().Tag = img;
                getFreeSlot().Tag = img;
                getFreeSlot().Tag = img;
            }

            specialPictureBox = getFreeSlot();
            specialPictureBox.Tag = "osobny";
            specialPictureBox.Image = Properties.Resources._6;
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
            ResetGuesses();
        }

        private void SPECIALTIMER_TICK(object sender, EventArgs e)
        {
            var specialPic = pictureBoxes.FirstOrDefault(p => p.Tag != null && p.Tag.ToString() == "osobny");
            if (specialPic != null)
            {
                specialPic.Visible = false;
            }
            specialTimer.Stop();
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            clickTimer.Stop();
            specialTimer.Stop();
            timer.Stop();
            this.Close();
        }

        private void startm_Click(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            specialTimer.Interval = 1000;
            specialTimer.Tick += SPECIALTIMER_TICK;
            startm.Enabled = false;
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (pic.Tag != null && pic.Tag.ToString() == "osobny")
            {
                pic.Image = Properties.Resources._6;
                specialTimer.Start();
                return;
            }

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            if (secondGuess == null)
            {
                secondGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            thirdGuess = pic;
            pic.Image = (Image)pic.Tag;

            if (firstGuess.Tag == secondGuess.Tag && secondGuess.Tag == thirdGuess.Tag && firstGuess != secondGuess && secondGuess != thirdGuess && firstGuess != thirdGuess)
            {
                firstGuess.Visible = false;
                secondGuess.Visible = false;
                thirdGuess.Visible = false;
                ResetGuesses();

                if (!pictureBoxes.Any(p => p.Visible))
                {
                    MessageBox.Show("Gratulacje!");
                    parent.SCORE = 1;
                    parent.RODZAJ = "Memory";
                    parent.Zapis_do_CSV();
                    ResetImages();
                }
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
        }

        private void ResetGuesses()
        {
            firstGuess = null;
            secondGuess = null;
            thirdGuess = null;
        }
    }
}
