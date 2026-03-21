namespace urzadzenia_mobilna
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ustawProgram(object sender, EventArgs e)
        {
            int nrProgramu = int.Parse(programEntry.Text);

            if(nrProgramu < 12 && nrProgramu > 1)
            {
                programPrania.Text = $"Numer prania: {nrProgramu}";
            }
        }

        bool czyWlaczony = false;
        private void wlaczWylaczOdkurzacz(object sender, EventArgs e)
        {

            if (!czyWlaczony)
            {
                czyWlaczony = true;
                stanOdkurzacza.Text = "Odkurzacz włączony";
                wlacznik.Text = "Wyłącz";
            }

            else
            {
                czyWlaczony = false;
                stanOdkurzacza.Text = "Odkurzacz wyłączony";
                wlacznik.Text = "Włącz";
            }
        }
    }

}
