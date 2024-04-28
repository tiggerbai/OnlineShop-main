using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShopCMS.Services;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{
    public class PromotionCondition
    {
        public int Id { get; set; }
        public string ConditionType { get; set; }
        public string Description { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }

}
