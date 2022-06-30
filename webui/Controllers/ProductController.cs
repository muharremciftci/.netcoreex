using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Models;
using webui.ViewModels;

namespace webui.Controllers
{
    public class ProductController:Controller
    {

        public IActionResult Index()
        {
            //ViewBag
            //Model
            //ViewData

            var product= new Product {Name="Iphone11",Price=15000,Description="İyidir iyi"};

            // ViewData["Product"]=product;
            // ViewData["Category"]="Telefonlar";

            ViewBag.Category="Telefonlar";
            // ViewBag.Product=product;


            return View(product);
        }
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                 new Product {Name="İphone11", Price=11000, Description="İyi telefon",IsApproved=false},
                  new Product {Name="İphone12", Price=15000, Description="İyi telefon",IsApproved=true},
                    new Product {Name="İphone13", Price=20000, Description="İyi telefon"},
                          new Product {Name="İphone13pro", Price=25000, Description="İyi telefon",IsApproved=false},
            };


                var category = new Category{Name="Telefonlar",Description="Telefon Kategorisi"};
                
                var productViewModel=new ProductViewModel()
                {
                    Category=category,
                    Products=products
                };


            return View(productViewModel);

        }


          public IActionResult Details()
        {   
            var product = new Product();
            product.Name="samsung 6";
            product.Price=3000;
            product.Description="iyi telefon";

            return View(product);

        }
    }
}