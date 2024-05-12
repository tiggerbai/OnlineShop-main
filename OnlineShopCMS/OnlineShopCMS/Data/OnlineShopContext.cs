using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Models;
using OnlineShopCMS.Areas.Identity.Data;

namespace OnlineShopCMS.Data
{
    public class OnlineShopContext : DbContext
    {
<<<<<<< HEAD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        
            modelBuilder.Entity<PromotionProduct>()
                .HasKey(pp => new { pp.PromotionId, pp.ProductId });
            modelBuilder.Entity<Promotion>()
       .Property(p => p.DiscountType)
       .HasConversion<string>();
        }

        public OnlineShopContext()
        {
        }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineShopCMS.Models.Product> Product { get; set; }
        public DbSet<OnlineShopCMS.Models.Promotion> Promotions { get; set; }
        public DbSet<PromotionRule> PromotionRules { get; set; }
        public DbSet<PromotionCondition> PromotionConditions { get; set; }
        public DbSet<OnlineShopCMS.Models.PromotionProduct> PromotionProducts { get; set; }
        public DbSet<OnlineShopCMS.Models.Category> Category { get; set; }
        public DbSet<OnlineShopCMS.Models.Comment> Comment { get; set; }
        public DbSet<OnlineShopCMS.Models.UserProfile> UserProfiles { get; set; }
        public DbSet<OnlineShopCMS.Models.Order> Order { get; set; }
        public DbSet<OnlineShopCMS.Models.OrderItem> OrderItem { get; set; }
        public DbSet<OnlineShopUser> OnlineShopUser { get; set; }
        public DbSet<OnlineShopCMS.Models.Ship> Ship { get; set; }

        public DbSet<OnlineShopCMS.Models.Coupon> Coupon { get; set; }



=======
        public OnlineShopContext (DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShopCMS.Models.Product> Product { get; set; }
        public DbSet<OnlineShopCMS.Models.Category> Category { get; set; }
        public DbSet<OnlineShopCMS.Models.Comment> Comment { get; set; }
        
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
    }
}
