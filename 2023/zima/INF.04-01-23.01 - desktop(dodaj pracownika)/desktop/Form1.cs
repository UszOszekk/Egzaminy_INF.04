using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracownicy_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string generujHaslo()
        {
            if (!int.TryParse(ileZnakowTB.Text, out int ileLiter) || ileLiter <= 0)
            {
                MessageBox.Show("Podaj poprawną liczbę znaków");
                return "";
            }

            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string liczby = "0123456789";
            string znaki = "!@#$%^&*()_+-=";

            Random random = new Random();

            string haslo = "";
            
            for (int i = 0; i < ileLiter; i++)
            {
                int wybor = random.Next(4);

                if (wybor == 0) haslo += maleLitery[random.Next(maleLitery.Length)];
                else if (wybor == 1 && cyfryCheck.Checked) haslo += liczby[random.Next(liczby.Length)];
                else if (wybor == 2 && znakiCheck.Checked) haslo += znaki[random.Next(znaki.Length)];
                else if (wybor == 3 && maleWielkieCheck.Checked) haslo += wielkieLitery[random.Next(wielkieLitery.Length)];
                else haslo += maleLitery[random.Next(maleLitery.Length)];
            }

            return haslo;
        }

        private string ostatnieHaslo = "";
        private void generujHasloBTN_Click(object sender, EventArgs e)
        {
            string noweHaslo = generujHaslo();
            if (string.IsNullOrEmpty(noweHaslo)) return;

            ostatnieHaslo = noweHaslo;

            MessageBox.Show("Wygenerowane hasło: " + ostatnieHaslo);
        }

        private void zatwierdzBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Dane pracownika: {imieTB.Text} {nazwiskoTB.Text} {stanowiskoCB.Text} Hasło: {ostatnieHaslo}"

            );
        }
    }
}
