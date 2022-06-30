using System;
using Microsoft.AspNetCore.Mvc;

namespace webui.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            
            ViewBag.Greeting = saat>12?"iyi günler":"Günaydın";
            ViewBag.UserName = "Muharrem";
            

            return View();
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