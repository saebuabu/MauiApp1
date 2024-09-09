namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Method that implents a button cluck to GotoPage1Button
        private async void OnGotoPage1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageStacklayout());
        }
    }

}
