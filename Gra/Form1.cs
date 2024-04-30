namespace Gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NyanCat nowe_okno = new NyanCat(this);
            nowe_okno.ShowDialog();
        }
    }
}
