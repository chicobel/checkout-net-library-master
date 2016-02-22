using Checkout.ApiServices.Shopping.RequestModels;
using Checkout.ApiServices.Shopping.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping
{
    public class ShoppingServiceAuthorizer
    {
        public ShoppingToken ShoppingToken { get; set; }

        public DateTime Expires { get; set; }

        LoginModel LoginModel { get; set; }

        public ShoppingServiceAuthorizer(LoginModel loginmdl)
        {
            LoginModel = loginmdl;
        }
        public void Authorize()
        {
            var resp = new ApiHttpClient().PostRequest<ShoppingToken>(ApiUrls.ShoppingToken, "open", LoginModel);
            ShoppingToken = resp.Model;
        }
    }
}
