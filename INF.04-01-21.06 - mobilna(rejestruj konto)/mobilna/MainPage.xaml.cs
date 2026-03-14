using Microsoft.Maui.ApplicationModel.Communication;

namespace INF._04_01_21._06_SG_mobilna_
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void submitLog(object sender, EventArgs e)
        {
            if (!email.Text.Contains('@'))
            {
                mailLabel.Text = "Nieprawidłowy adres e-mail";
            }

            else if (password.Text != repeatedPassword.Text)
            {
                mailLabel.Text = "Hasła się różnią";
            }

            else
            {
                mailLabel.Text = $"Witaj {email.Text}";
            }
        }
    }
}
