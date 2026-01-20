namespace INF._04_02_23._06_SG_mobile_
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           double wartoscSLidera = Math.Round(slider2.Value);
            rozmiarText.Text = "Rozmiar: "+  wartoscSLidera;
            Cytat.FontSize = wartoscSLidera;
        }

        string[] przywitania = { "Dzień dobry", "Good morning","Buenos dias"};
        int nrPrzywitania = 0;

        private void przycisk_Clicked(object sender, EventArgs e)
        {

            nrPrzywitania++;
            if(nrPrzywitania == 3)
            {
                nrPrzywitania = 0;
            }
            Cytat.Text = przywitania[nrPrzywitania].ToString();

        }
    }
}
