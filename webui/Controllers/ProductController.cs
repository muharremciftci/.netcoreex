using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Data;
using webui.Models;
using webui.ViewModels;

namespace webui.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            //ViewBag
            //Model
            //ViewData

            var product = new Product { Name = "Iphone11", Price = 15000, Description = "İyidir iyi" };

            // ViewData["Product"]=product;
            // ViewData["Category"]="Telefonlar";

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product=product;


            return View(product);
        }
        public IActionResult List()
        {

            // var category = new Category{Name="Telefonlar",Description="Telefon Kategorisi"};                
            var productViewModel = new ProductViewModel()
            {

                Products = ProductRepository.Products
            };


            return View(productViewModel);

        }


        public IActionResult Details()
        {
            var product = new Product();
            product.Name = "samsung 6";
            product.Price = 3000;
            product.Description = "iyi telefon";

            return View(product);

        }
    }
}