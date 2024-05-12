using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Data
{
    public class OnlineShopContext : DbContext
    {
<<<<<<< HEAD
        public OnlineShopContext()
        {
        }

=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        public OnlineShopContext (DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShop.Models.Product> Product { get; set; }
        public DbSet<OnlineShop.Models.Category> Category { get; set; }
        public DbSet<OnlineShop.Models.Order> Order { get; set; }
        public DbSet<OnlineShop.Models.OrderItem> OrderItem { get; set; }
<<<<<<< HEAD
        public DbSet<OnlineShop.Models.Comment> Comment { get; set; }

        public DbSet<OnlineShop.Models.Coupon> Coupon { get; set; }
=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
    }
}
