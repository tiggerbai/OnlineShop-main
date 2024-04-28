using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }

        public int OrderId { get; set; }
        = 0;
        public List<CartItem> CartItems { get; set; }
    }
}
