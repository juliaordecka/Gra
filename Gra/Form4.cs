using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace Gra
{
    public partial class Form4 : Form
    {
        public string nick;
        User usr = new User();
        public List<User> list = new List<User>();
        public Form4()
        {
            InitializeComponent();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
            usr.Nickname = nick;
            usr.Score = 0;

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };

            if (!File.Exists("users.csv"))
            {
                list.Add(usr);
                File.Create("users.csv").Close(); // Ensure the file is closed after creation

                using (var writer = new StreamWriter("users.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(list);
                }
            }
            else
            {
                list = LoadData("users.csv");
                bool ifExists = list.Any(user => user.Nickname == nick);
                if (ifExists)
                {
                    infoLabel.Text = "Taki uzytkownik juz istnieje, jesli to ty, kliknij zatwierdz.";
                }
                else
                {
                    infoLabel.Text = "Kliknij zatwierdz";
                    list.Add(usr);

                    using (var writer = new StreamWriter("users.csv"))
                    using (var csv = new CsvWriter(writer, config))
                    {
                        csv.WriteRecords(list);
                    }
                }
            }
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static List<User> LoadData(string filename)
        {
            List<User> users = new List<User>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = true,
            };

            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, config))
            {
                // Wczytanie danych do listy obiektów
                users = csv.GetRecords<User>().ToList();
            }

            return users;
        }


        private void zatwierdz_Click(object sender, EventArgs e)
        {
            //przypisz odpowiednie wartosci jesli np uztykownik istnieje, ustaw punkty
            //przeslij dane obiektu do formualarza glownego
            //w formularzu glownym przypisz do obiektu currentuser nick i punkty
            //po kazdej grze dodawaj punkty do uzytkownika i uaktualniaj liste w programie i w csv
            //wyswietl?
        }
    }
}

