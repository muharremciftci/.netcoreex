using System.Collections.Generic;
using System.Linq;
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


            //product/list => tüm ürünler gelsin
            //product/list/2 => belli ürünler glesin
        }
        public IActionResult List(int? id, string q)
        {

            // var category = new Category{Name="Telefonlar",Description="Telefon Kategorisi"};      

            var products = ProductRepository.Products; //tüm listeleme

           
             if (id!=null) // id ye göre listeleme
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q)) //searchbox listeleme
            {
                 products=products.Where(i=>i.Name.ToLower().Contains(q) || i.Description.ToLower().Contains(q)).ToList();
            }

              var productViewModel = new ProductViewModel()
            {

                Products = products
            };

            return View(productViewModel);

        }


        public IActionResult Details(int id)
        {
          

            return View(ProductRepository.GetProductById(id));

        }
   
        public IActionResult Create()
        {
            return View();
        }
    }
}