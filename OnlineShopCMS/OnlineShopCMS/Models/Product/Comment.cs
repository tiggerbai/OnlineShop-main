using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Rating { get; set; }

    }

}
