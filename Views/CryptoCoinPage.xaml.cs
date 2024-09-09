using MauiApp1.Controllers;

namespace MauiApp1.Views;


public partial class CryptoCoinPage : ContentPage
{
	public CryptoCoinPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {

        //Call the GetCryptoCoinsAsync method to get the list of cryptocurrencies
        var cryptoCoins = await CryptoCoinService.GetCryptoCoinsAsync();

        //sorteer de lijst van cryptocurrencies op basis van de prijs van hoog naar laag
        cryptoCoins = cryptoCoins.OrderByDescending(c => c.Price_usd).ToList();

        //Bind the list of cryptocurrencies to the ListView
        CryptoCoinsListView.ItemsSource = cryptoCoins;
    }
}