namespace Gra
{
    public partial class Form1 : Form
    {
        User currUser = new User();
        public List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            //walnij dydelf
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pasjans
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void Form4_DataPassed(string nick, int score)
        {
            currUser.Nickname = nick; //dane uzytkownika
            currUser.Score = score;
            label2.Text = nick.ToString();
            //po kazdej grze dodawaj punkty do uzytkownika i uaktualniaj liste w programie i w csv
            //wyswietl?
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.DataPassed += Form4_DataPassed;
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NyanCat nowe_okno = new NyanCat(this);
            nowe_okno.ShowDialog();

        }
    }
}
