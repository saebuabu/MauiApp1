using MauiApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Controllers
{
    public class CryptoCoinService
    {
        static readonly HttpClient client = new();

        /*
         * This method is used to get the list of all the cryptocurrencies
         *  from the API
         */
        static public async Task<List<CryptoCoin>> GetCryptoCoinsAsync()
        {
            try
            {
                //Initiate the HttpRequest
                var url = "https://api.coinlore.net/api/tickers/";
                var response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                //Deserialize the JSON response
                if (string.IsNullOrEmpty(response.Content.ToString()))
                {
                    return new List<CryptoCoin>();
                }

                var content = await response.Content.ReadAsStringAsync();
                if (String.IsNullOrEmpty(content))
                {
                    return new List<CryptoCoin>();
                }
                ApiResponse? api = JsonConvert.DeserializeObject<ApiResponse>(content) ?? new ApiResponse();

                return api.Data.ToList() ?? new List<CryptoCoin>();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return new List<CryptoCoin>();
            }
        }

        // https://api.coinlore.net/api/ticker/?id=90
        // This method is used to get the actual details of bitcoin
        static public async Task<CryptoCoin> GetBitcoinAsync()
        {
            try
            {
                //Initiate the HttpRequest
                var url = "https://api.coinlore.net/api/ticker/?id=90";
                var response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                //Deserialize the JSON response
                if (string.IsNullOrEmpty(response.Content.ToString()))
                {
                    return new CryptoCoin();
                }

                var content = await response.Content.ReadAsStringAsync();
                if (String.IsNullOrEmpty(content))
                {
                    return new CryptoCoin();
                }


                return JsonConvert.DeserializeObject<List<CryptoCoin>>(content).FirstOrDefault<CryptoCoin>() ?? new CryptoCoin();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return new CryptoCoin();
            }
        }

    }
}
