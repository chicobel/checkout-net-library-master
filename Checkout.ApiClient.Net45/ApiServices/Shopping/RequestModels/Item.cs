using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.RequestModels
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
