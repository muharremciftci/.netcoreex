using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webui.Data;
using webui.Models;

namespace webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        

            return View(CategoryRepository.Categories);
        }
        
    }
}