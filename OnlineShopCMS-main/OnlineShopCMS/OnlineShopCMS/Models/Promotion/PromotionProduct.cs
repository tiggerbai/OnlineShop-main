using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{
    public class PromotionProduct
    {
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
