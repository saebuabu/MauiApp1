
using MauiApp1.Controllers;
using MauiApp1.Models;

namespace MauiApp1.Views;



public partial class BitcoinPage : ContentPage
{
	public BitcoinPage()
	{
		InitializeComponent();
        GetBitcoinData();
    }

    //async method to retrieve bitcoin details
    private async void GetBitcoinData()
    {
        //Call the GetBitcoinAsync method to get the details of bitcoin
        var bitcoin = await CryptoCoinService.GetBitcoinAsync();
        //Bind the bitcoin details to the Label controls
        NameLabel.Text = bitcoin.Name;
        SymbolLabel.Text = bitcoin.Symbol;
        PriceLabel.Text = bitcoin.Price_usd.ToString();
        PercentChangeLabel.Text = bitcoin.Percent_change_1h.ToString();
    }
}