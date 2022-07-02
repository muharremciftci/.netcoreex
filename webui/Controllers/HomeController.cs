using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Models;
using webui.ViewModels;

namespace webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Product>()
            {
                 new Product {Name="İphone11", Price=11000, Description="İyi telefon",IsApproved=false},
                  new Product {Name="İphone12", Price=15000, Description="İyi telefon",IsApproved=true},
                    new Product {Name="İphone13", Price=20000, Description="İyi telefon"},
                          new Product {Name="İphone13pro", Price=25000, Description="İyi telefon",IsApproved=false},
            };



            var productViewModel = new ProductViewModel()
            {
               
                Products = products
            };


            return View(productViewModel);

        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}