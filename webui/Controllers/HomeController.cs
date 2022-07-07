using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Data;
using webui.Models;
using webui.ViewModels;

namespace webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

        


            var productViewModel = new ProductViewModel()
            {
               
                Products = ProductRepository.Products
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