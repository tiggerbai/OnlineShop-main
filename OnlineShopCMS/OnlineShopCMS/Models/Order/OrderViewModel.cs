using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCMS.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
