using Checkout;
using Checkout.ApiServices.Shopping;
using Checkout.ApiServices.Shopping.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
            AppSettings.SetEnvironmentFromConfig();
            var auth = new ShoppingServiceAuthorizer(new LoginModel{username="myusername",password="checkout.com"});
            auth.Authorize();
            var shpServc = new ShoppingService(auth.ShoppingToken);
            var lst = shpServc.GetShoppingList(new Checkout.ApiServices.Shopping.ResponseModels.ShoppingList { });
            foreach (var item in lst.Model.Items)
            {
                Console.WriteLine("name:{0} Quantity:{1}", item.Item.Name, item.Quantity);
            }
            Console.ReadLine();
        }
    }
}
