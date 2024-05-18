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
    public partial class ranking : Form
    {
        public ranking()
        {
            InitializeComponent();
            LoadDataFromCSV();
        }

        private void LoadDataFromCSV()
        {
            string filePath = @"C:\temp\Users.csv";
            char delimiter = ';';

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik Users.csv nie istnieje.");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Plik Users.csv jest pusty.");
                    return;
                }

                // Dodaj kolumny do DataGridView na podstawie nagłówków z pliku
                var headers = lines[0].Split(delimiter);
                foreach (var header in headers)
                {
                    dataGridViewRanking.Columns.Add(header, header);
                }

                // Dodaj wiersze do DataGridView
                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(delimiter);
                    if (values.Length == headers.Length)
                    {
                        dataGridViewRanking.Rows.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu pliku: {ex.Message}");
            }
        }
    }
}
