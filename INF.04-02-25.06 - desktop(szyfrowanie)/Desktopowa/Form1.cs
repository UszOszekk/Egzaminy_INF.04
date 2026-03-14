namespace INF._04_02_25._06_SG_desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kluczTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = jawnyTextBox.Text;
            int klucz = 0;
            if (int.TryParse(kluczTextBox.Text, out int result))
            {
                klucz = int.Parse(kluczTextBox.Text);
            }
            else
            {
                kluczTextBox.Text = "0";
                klucz = 0;
            }

                string tekstZaszyfrowany = "";
            int literaWASCII = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                literaWASCII = (int)tekst[i];
                if (literaWASCII >= 97 && literaWASCII <= 122)
                {
                    literaWASCII = literaWASCII + klucz;
                    if (literaWASCII > 122)
                        literaWASCII -= 26;
                    else if (literaWASCII < 97)
                        literaWASCII += 26;
                }

                char literaPrzekonwertowana = (char)literaWASCII;
                tekstZaszyfrowany += literaPrzekonwertowana;
            }
            zaszyfrowanyText.Text = tekstZaszyfrowany;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog zapiszPlik = new SaveFileDialog();
            zapiszPlik.Filter = "Pliki tekstowe (*.txt) | *.txt";
            if(zapiszPlik.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(zapiszPlik.FileName,zaszyfrowanyText.Text);
            }
            
        }
    }
}
