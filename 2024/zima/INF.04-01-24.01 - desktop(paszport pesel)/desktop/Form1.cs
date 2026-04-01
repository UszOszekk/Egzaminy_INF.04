using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paszporty_desktopowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numerTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerTB_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(numerTB.Text))
            {
                zdjecie_pictureBox.Image = null;
                odcisk_pictureBox.Image = null;
                return;
            }

            int numer = int.Parse(numerTB.Text);

            switch (numer)
            {
                case 000:
                    zdjecie_pictureBox.Image = Properties.Resources._000_zdjecie;
                    odcisk_pictureBox.Image = Properties.Resources._000_odcisk;
                    break;

                case 111:
                    zdjecie_pictureBox.Image = Properties.Resources._111_zdjecie;
                    odcisk_pictureBox.Image = Properties.Resources._111_odcisk;
                    break;

                case 333:
                    zdjecie_pictureBox.Image = Properties.Resources._333_zdjecie;
                    odcisk_pictureBox.Image = Properties.Resources._333_odcisk;
                    break;

                default:
                    zdjecie_pictureBox.Image = null;
                    odcisk_pictureBox.Image = null;
                    break;

            }
            
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(imieTB.Text) || string.IsNullOrEmpty(nazwiskoTB.Text)) {
                MessageBox.Show("Wprowadź dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string kolorOczu;

            if (niebieskieRB.Checked)
            {
                kolorOczu = niebieskieRB.Text;
            }

            else if (zieloneRB.Checked)
            {
                kolorOczu = zieloneRB.Text;
            }

            else
            {
                kolorOczu = piwneRB.Text;
            }

                MessageBox.Show($"{imieTB.Text} {nazwiskoTB.Text} kolor oczu {kolorOczu}");
        }
    }
}
