namespace INF._04_01_22._06_SG_mobilna_
{
    public partial class MainPage : ContentPage
    {
        int polubienia = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPolubClicked(object sender, EventArgs e)
        {
            polubienia++;
            PolubienieText.Text = polubienia + " polubień";

        }
        private void OnUsunClicked(object sender, EventArgs e)
        {
            if (polubienia > 0)
            {
                polubienia--;
            }
            PolubienieText.Text = polubienia + " polubień";


        }
    }
}
