using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.Shopping.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.ResponseModels
{
    public class ShoppingList: BasePagination
    {
        public List<ShoppingItem> Items { get; set; }
        public int? Limit { get; set; }
    }
}
