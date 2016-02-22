using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.RequestModels
{
    public class ShoppingItem
    {
        public int Quantity { get; set; }
        public Item Item { get; set; }
    }
}
