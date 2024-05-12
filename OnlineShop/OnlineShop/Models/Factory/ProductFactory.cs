using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using OnlineShop.Data;
using OnlineShop.Models;


namespace OnlineShop.Models
{
    public class ProductFactory
    {
        OnlineShopContext db = new OnlineShopContext();

        public Product CreateProduct(string name, string description, string content, int price, int stock, byte[] image, int categoryId)
        {
            return new Product
            {
                Name = name,
                Description = description,
                Content = content,
                Price = price,
                Stock = stock,
                Image = image,
                CategoryId = categoryId
            };
        }

        public double AverageRating(Product product)
        {
            return product.Comments.Any()
                ? product.Comments.Average(comment => comment.Ratiing)
                : 0;
        }



        //    double averageRating = Product.Comments.Average(comment => comment.Ratiing);
        //    double averageRating = product.Comments.Any()
        //? product.Comments.Average(comment => comment.Ratiing)
        //: 0;


    }
}
