using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF._04_01_23._06_SG_desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zdjecie.Image = Properties.Resources.pocztowka;
        }

        private void sprawdzCeneBtn_Click(object sender, EventArgs e)
        {
            if (list.Checked)
            {
                zdjecie.Image = Properties.Resources.list;
                cenaTxt.Text = "Cena: 1 zł";
            }
            else if (pocztowka.Checked)
            {
                zdjecie.Image = Properties.Resources.pocztowka;
                cenaTxt.Text = "Cena: 1,5 zł";
            }
            else if (paczka.Checked)
            {
                zdjecie.Image = Properties.Resources.paczka;
                cenaTxt.Text = "Cena: 10 zł";
            }
        }

        private void zatwierdzBtn_Click(object sender, EventArgs e)
        {
            if (kodPocztowy.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (int.TryParse(kodPocztowy.Text, out int result) == false)
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            
                    
        }
    }
}
