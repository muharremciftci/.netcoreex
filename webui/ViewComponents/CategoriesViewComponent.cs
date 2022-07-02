using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories= new List<Category>()
            {
                new Category {Name="Telefonlar",Description="Telefonlar Kategorisi"},
                new Category {Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                new Category {Name="Elektronik",Description="Elektronik Kategorisi"},
            };

            return View(categories);
        }
        
    }
}