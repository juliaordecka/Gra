namespace Gra
{
    public partial class Form1 : Form
    {
        public string NICK = "Gosc";
        public int SCORE = 0;
        public string RODZAJ = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            //walnij dydelf
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //memory
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Logowanie nowe_okno = new Logowanie(this);
            nowe_okno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nyan cat
            NyanCat nowe_okno = new NyanCat(this);
            nowe_okno.ShowDialog();

        }

        public void Zapis_do_CSV()
        {
            string folderPath = @"C:\temp";
            string filePath = Path.Combine(folderPath, "Users.csv");
            string delimiter = ";";

            try
            {
                // Upewnij siê, ¿e katalog istnieje
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Tworzenie nag³ówków w pliku, jeœli jeszcze nie istnieje
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine($"NICK{delimiter}SCORE{delimiter}RODZAJ_GRY");
                    }
                }

                // Dodawanie danych do pliku
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{NICK}{delimiter}{SCORE}{delimiter}{RODZAJ}");
                }

                MessageBox.Show("Dane zosta³y zapisane pomyœlnie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d podczas zapisywania danych: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ranking nowe_okno = new ranking();
            nowe_okno.Show();
        }
    }
}
