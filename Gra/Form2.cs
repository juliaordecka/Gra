using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Timer = System.Windows.Forms.Timer;

namespace Gra
{
    public partial class Form2 : Form
    {
        Form1 parent;
        bool allowClick = false;
        Random rnd = new Random();
        PictureBox firstGuess;
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
                    Properties.Resources._5,
                    Properties.Resources._6,
                    Properties.Resources._7,
                    Properties.Resources._8

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
                    MessageBox.Show("Koniec czasu");
                    //ZAPIS WYNIKU
                    parent.SCORE = 0;
                    parent.RODZAJ = "Memory";
                    parent.Zapis_do_CSV();
                    //////////////////
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
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.x;
            }
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
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }




        private void wyjdz_Click(object sender, EventArgs e)
        {
            clickTimer.Stop();
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
            startm.Enabled = false;
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else { allowClick = false; clickTimer.Start(); }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("Gratulacje");
            //ZAPIS WYNIKU
            parent.SCORE = 1;
            parent.RODZAJ = "Memory";
            parent.Zapis_do_CSV();
            ////////////////////////
            ResetImages();

        }


    }
}

