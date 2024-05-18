using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Media;
using System.Numerics;


namespace Gra
{
    public partial class NyanCat : Form
    {
        Form1 parent;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<PictureBox> Donuts = new List<PictureBox>();
        private List<PictureBox> zdobyteDonuts = new List<PictureBox>();
        bool koniec_gry = false;
        int serca = 4;
        int score = 0;
        private Random random = new Random();
        private int stepSize = 7; // Rozmiar kroku przesunięcia
        private int milisek = 50;
        
        public NyanCat(Form1 parent)
        {
            InitializeComponent();
            InitializeTimer();
            InitializeMeteors();
            InitializeDonuts();
            this.parent = parent;
            this.Size = new Size(900, 600);
            Image backgroundImage = zasoby.tlo;
            this.BackgroundImage = backgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.KeyDown += Nyan_KeyDown;
            PlayMusic("NyanCatMusic.wav");
            this.FormClosed += new FormClosedEventHandler(NyanCat_FormClosed);
        }
        SoundPlayer musicPlayer = new SoundPlayer();
        public void PlayMusic(string filename)
        {
            musicPlayer.SoundLocation = filename;
            musicPlayer.Play();
        }

        private void NyanCat_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicPlayer.Stop();
        }

        private void InitializeMeteors()
        {
            int numberOfPictureBoxes = 18; // liczba PictureBoxów
            int currentY = 175; // Początkowa wartość x dla pierwszych trzech PictureBoxów
            int spacing = 50; // Odległość między grupami PictureBoxów
            int countPerGroup = 3; // Ilość PictureBoxów w każdej grupie

            for (int i = 0; i < numberOfPictureBoxes; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = zasoby.meteor;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(50, 50);

                // losowanie lokalizacji zeby sie nie nakladalo
                Point newLocation;
                bool locationIsOccupied;
                do
                {
                    newLocation = new Point(random.Next(ClientSize.Width - pictureBox.Width), currentY);
                    locationIsOccupied = false;
                    foreach (PictureBox existingPictureBox in pictureBoxes)
                    {
                        if (new Rectangle(newLocation, pictureBox.Size).IntersectsWith(existingPictureBox.Bounds))
                        {
                            locationIsOccupied = true;
                            break;
                        }
                    }
                } while (locationIsOccupied);

                // Ustawienie nowej lokalizacji dla PictureBoxa
                pictureBox.Location = newLocation;
                // Zwiększ wartość x dla kolejnej grupy PictureBoxów
                if ((i + 1) % countPerGroup == 0)
                {
                    currentY += spacing;
                }
                Controls.Add(pictureBox);
                pictureBoxes.Add(pictureBox);
            }
        }

        private void InitializeDonuts()
        {
            int currentY = 175;
            int spacing = 50;
            int countPerGroup = 1;

            for (int i = 0; i < 5; i++)
            {
                PictureBox donut = new PictureBox();
                donut.Image = zasoby.donut;
                donut.SizeMode = PictureBoxSizeMode.StretchImage;
                donut.Size = new Size(50, 50);

                Point newLocation;
                bool locationIsOccupied;
                do
                {
                    newLocation = new Point(random.Next(ClientSize.Width - donut.Width), currentY);
                    locationIsOccupied = false;
                    foreach (PictureBox existingDonut in Donuts)
                    {
                        if (new Rectangle(newLocation, donut.Size).IntersectsWith(existingDonut.Bounds))
                        {
                            locationIsOccupied = true;
                            break;
                        }
                    }
                } while (locationIsOccupied);

                donut.Location = newLocation;
                if ((i + 1) % countPerGroup == 0)
                {
                    currentY += spacing;
                }
                Controls.Add(donut);
                Donuts.Add(donut);
            }
        }
        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = milisek; // Interwał w milisekundach (czas pomiędzy kolejnymi wywołaniami Timer_Tick)
            timer1.Tick += Timer_Tick;
            timer1.Start();

            //przyspieszanie meteorow co minutke
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 30000;
            timer2.Tick += Timer_Tick2;
            timer2.Start();
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            // Zwiększenie prędkości przesuwania meteorów
            stepSize += 1; // Możesz dostosować wartość, o którą chcesz zwiększyć prędkość

            // Możesz dodać tutaj kod do aktualizacji prędkości przesuwania meteorów na formularzu
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int interval = 1;
            foreach (var pictureBox in pictureBoxes)
            {
                int currentX = pictureBox.Location.X;
                //rozne szybkosci meteorow dla trudnosci
                if (interval % 2 == 0)
                {
                    // przesuwanie w prawo o stepSize pikseli
                    pictureBox.Location = new Point(currentX + stepSize, pictureBox.Location.Y);
                }
                else { pictureBox.Location = new Point(currentX + stepSize + 3, pictureBox.Location.Y); }

                // przenieś na początek
                if (pictureBox.Location.X > this.ClientSize.Width)
                {
                    pictureBox.Location = new Point(0, pictureBox.Location.Y);
                }
                interval++;
                Refresh();
            }
            //jesli nyancat nalozy sie z ktoryms to odejmuje serce
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Bounds.IntersectsWith(nyan.Bounds))
                {
                    OdejmijSerce();
                }
            }
            List<PictureBox> donutsCopy = new List<PictureBox>(Donuts);
            foreach (PictureBox donut in donutsCopy)
            {
                if (donut.Bounds.IntersectsWith(nyan.Bounds) && !zdobyteDonuts.Contains(donut))
                {
                    zdobyteDonuts.Add(donut);
                    donut.Visible = false;
                    score++;
                    string scoreText = score.ToString();
                    scoreLabel.Text = scoreText;
                    if (zdobyteDonuts.Count%4 == 0)
                    {
                        InitializeDonuts();
                    }
                }
            }
            if (tecza.Bounds.IntersectsWith(nyan.Bounds))
            {
                nyan.Location = new Point(425, 475);
            }

        }


        private void Nyan_KeyDown(object sender, KeyEventArgs e)
        {
            int x = nyan.Location.X;
            int y = nyan.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    y -= 50;
                    break;
                case Keys.Down:
                    y += 50;
                    break;
                case Keys.Left:
                    x -= 50;
                    break;
                case Keys.Right:
                    x += 50;
                    break;
            }
            //jesli nyancat wyjdzie poza obszar to wychodzi z przeciwnej strony
            if (nyan.Location.X > this.ClientSize.Width)
            {
                nyan.Location = new Point(0, y);
            }
            else if (nyan.Location.X < 0)
            {
                nyan.Location = new Point(this.ClientSize.Width, y);
            }
            else { nyan.Location = new Point(x, y); }

        }

        private void OdejmijSerce()
        {
            serca--;
            if (serca > 0)
            {
                if (serca == 3)
                {
                    serce1.Image = zasoby.serce_biale;
                    serce1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (serca == 2)
                {
                    serce2.Image = zasoby.serce_biale;
                    serce2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (serca == 1)
                {
                    serce3.Image = zasoby.serce_biale;
                    serce3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                serce4.Image = zasoby.serce_biale;
                serce4.SizeMode = PictureBoxSizeMode.StretchImage;
                koniec_gry = true;
                SprawdzKoniecGry();
            }
        }

        private void HideControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                HideControls(c); // Rekurencyjnie ukrywaj kontrolki w kontenerach podrzędnych
                c.Visible = false;
            }
        }

        private void SprawdzKoniecGry()
        {
            if (koniec_gry)
            {
                timer1.Stop();
                this.KeyDown -= Nyan_KeyDown;

                // ukrywanie wszystkich kontrolek
                HideControls(this);

                Image backgroundImage = zasoby.game_over;
                this.BackgroundImage = backgroundImage;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                System.Windows.Forms.Label labelScore = new System.Windows.Forms.Label();
                //Label labelScore = new Label();
                labelScore.Text = "SCORE: " + score.ToString();
                labelScore.Location = new Point(375, 400);
                labelScore.AutoSize = true;
                labelScore.Font = new Font(labelScore.Font.FontFamily, 18, FontStyle.Bold); // Ustawienie pogrubionego fontu o rozmiarze 16
                labelScore.BackColor = SystemColors.HotTrack; // Ustawienie koloru tła na HotTrack
                this.Controls.Add(labelScore);
                musicPlayer.Stop();
                musicPlayer.Dispose(); // Zwolnienie zasobów

                parent.SCORE = score;
                parent.RODZAJ = "NyanCat";
                parent.Zapis_do_CSV();
            }
        }

    }
}