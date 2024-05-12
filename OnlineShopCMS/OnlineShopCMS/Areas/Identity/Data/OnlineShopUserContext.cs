using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Areas.Identity.Data;

namespace OnlineShopCMS.Data
{
    public class OnlineShopUserContext : IdentityDbContext<OnlineShopUser>
    {
        public OnlineShopUserContext(DbContextOptions<OnlineShopUserContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD

=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
