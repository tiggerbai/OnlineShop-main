using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace OnlineShopCMS.Models
{
    public class SearchViewModel
    {
        public SearchCriteria Criteria { get; set; }
        public List<Order> SearchResult { get; set; }
    }

}
