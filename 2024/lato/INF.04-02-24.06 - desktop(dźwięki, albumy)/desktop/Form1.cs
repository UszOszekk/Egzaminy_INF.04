using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dzwieki_desktopowa
{
    public partial class Form1 : Form
    {
        private List<Album> albums = new List<Album>();
        private int indeks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WczytajDane();
            PokazAlbum(indeks);
        }

        private void WczytajDane()
        {
            string path = Path.Combine(Application.StartupPath, "Data.txt");

            string[] lines = File.ReadAllLines(path);
            albums.Clear();

            for (int i = 0; i < lines.Length;)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    i++;
                    continue;
                }

                Album a = new Album
                {
                    artysta = lines[i++],
                    tytul = lines[i++],
                    liczbaPiosenek = int.Parse(lines[i++]),
                    rok = int.Parse(lines[i++]),
                    liczbaPobran = int.Parse(lines[i++])
                };

                albums.Add(a);
            }
        }

        private void PokazAlbum(int index)
        {
            if (albums.Count == 0) return;

            var a = albums[index];
            wykonawcaLBL.Text = a.artysta;
            tytulLBL.Text = a.tytul;
            liczbaUtworowLBL.Text = $"{a.liczbaPiosenek}";
            rokLBL.Text = $"{a.rok}";
            liczbaPobranLBL.Text = $"{a.liczbaPobran}";
        }
        private void pobierzBTN_Click(object sender, EventArgs e)
        {
            if (albums.Count == 0) return;

            albums[indeks].liczbaPobran++;
            liczbaPobranLBL.Text = $"{albums[indeks].liczbaPobran}";
        }

        private void lewoBTN_Click(object sender, EventArgs e)
        {
            if (albums.Count == 0)
            {
                return;
            }

            indeks--;
            if(indeks < 0)
            {
                indeks = albums.Count - 1;
            }

            PokazAlbum(indeks);
        }

        private void prawoBTN_Click(object sender, EventArgs e)
        {
            if (albums.Count == 0)
            {
                return;
            }

            indeks++;
            if (indeks >= albums.Count)
            {
                indeks = 0;
            }

            PokazAlbum(indeks);
        }
    }
    public class Album
    {
        public string artysta;
        public string tytul;
        public int liczbaPiosenek;
        public int rok;
        public int liczbaPobran;
    }
}
