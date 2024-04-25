using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            generatecards();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        //create solitaire spread - przycisk rozloz
        private void button1_Click(object sender, EventArgs e)
        {
            //Starting from left to right, place the first card face up to make the first pile, deal one card face down for the next six piles. Starting again from left to right, place one card face up on the second pile and deal one card face down on piles three through seven. Starting again from left to right, place one card face up on the third pile and deal one card face down on piles four through seven. Continue this pattern until pile seven has one card facing up on top of a pile of six cards facing down.


        }

        //generate cards
        private void generatecards()
        {
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(50 + 100 * i, 50 + 20 * j);
                    pictureBox.Size = new Size(100, 150);
                    pictureBox.Image = Image.FromFile("C:\\Users\\Julia\\Desktop\\lab chlorofil.jpg");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += pictureBox_Click;
                    Controls.Add(pictureBox);
                }
            }
        }

        private void pictureBox_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
