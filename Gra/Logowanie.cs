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
    public partial class Logowanie : Form
    {
        Form1 parent;
        public Logowanie(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            parent.NICK = nickname.Text;
            parent.label2.Text = nickname.Text;
            this.Close();
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
