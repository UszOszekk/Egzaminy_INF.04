using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aktualizujKolor()
        {
            int r = czerwonyTrackBar.Value;
            int g = zielonyTrackBar.Value;
            int b = niebieskiTrackBar.Value;

            czerwonyWartosc.Text = r.ToString();
            zielonyWartosc.Text = g.ToString();
            niebieskiWartosc.Text = b.ToString();

            kolorPanel.BackColor = Color.FromArgb(r, g, b);
        }
        private void pobierzBTN_Click(object sender, EventArgs e)
        {
            int r = czerwonyTrackBar.Value;
            int g = zielonyTrackBar.Value;
            int b = niebieskiTrackBar.Value;

            wartosciKoloruLBL.BackColor = Color.FromArgb(r, g, b);
            wartosciKoloruLBL.Text = $"{r}, {g}, {b}";
        }

        private void czerwonyTrackBar_Scroll(object sender, EventArgs e)
        {
            aktualizujKolor();
        }

        private void zielonyTrackBar_Scroll(object sender, EventArgs e)
        {
            aktualizujKolor();
        }

        private void niebieskiTrackBar_Scroll(object sender, EventArgs e)
        {
            aktualizujKolor();
        }
    }
}
