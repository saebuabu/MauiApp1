using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class CryptoCoin
    {
        //{"id":"90","symbol":"BTC","name":"Bitcoin","nameid":"bitcoin","rank":1,"price_usd":"58317.74",
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string NameId { get; set; }
        public int Rank { get; set; }
        public double Price_usd { get; set; }
    }
}
