using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{ 
    public class PromotionTarget
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }

        public TargetType? TargetType { get; set; }

        public int? TargetId { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
    public enum TargetType
    {
        AllProducts,
        SpecificCategory,
        SpecificProduct,
        FirstTimeBuyers,
        ReturningCustomers,
        Other
    }
   
}
