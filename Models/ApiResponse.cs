using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ApiResponse
    {
        public List<CryptoCoin>? Data { get; set; }
        public string? Status;
    }
}
