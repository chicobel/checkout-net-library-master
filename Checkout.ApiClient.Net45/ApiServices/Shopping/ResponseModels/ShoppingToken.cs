using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.ResponseModels
{
    public class ShoppingToken
    {
        public string Token { get; set; }

        public DateTime Expiry { get; set; }
    }
}
