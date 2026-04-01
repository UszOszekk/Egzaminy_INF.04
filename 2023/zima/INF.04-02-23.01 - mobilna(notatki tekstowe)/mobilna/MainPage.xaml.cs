using System.Collections.ObjectModel;

namespace proste_notatki_tekstowe
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>() {"Zakupy: chleb, masło, ser", "Do zrobienia: obiad, umyć podłogi", "weekend: kino, spacer z psem" };
            BindingContext = this;
        }

        private void DodajBtnClicked(object? sender, EventArgs e)
        {
            string text = WprowadzanieTextBox.Text;
            Items.Add(text);
        }
    }
}
