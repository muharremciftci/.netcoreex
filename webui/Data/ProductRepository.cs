using System.Collections.Generic;
using System.Linq;
using webui.Models;

namespace webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                     new Product {ProductId=1, Name="İphone11", Price=11000, Description="İyi telefon",IsApproved=false,ImageUrl="1.png"},
                  new Product {ProductId=2,Name="İphone12", Price=15000, Description="İyi telefon",IsApproved=true,ImageUrl="2.png"},
                    new Product {ProductId=3,Name="İphone13", Price=20000, Description="İyi telefon",IsApproved=true,ImageUrl="3.png"},
                          new Product {ProductId=4,Name="İphone13pro", Price=25000, Description="İyi telefon",IsApproved=false,ImageUrl="4.png"}
            };
        }

        public static List<Product> Products
        {
          get{
            return _products;
          }    
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public static Product GetProductById(int id)
        {
                return _products.FirstOrDefault(p=>p.ProductId==id);
        }

    }
}