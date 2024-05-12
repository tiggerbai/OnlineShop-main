using System.Collections.Generic;

namespace OnlineShop.Models
{
    public class ProductsByCategoryViewModel
    {
        public Dictionary<string, List<DetailViewModel>> ProductsByCategory { get; set; }

    }
}
