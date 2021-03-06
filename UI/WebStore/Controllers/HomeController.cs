using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Status(string id)
        {
            switch (id)
            {
                default: return Content($"Status --- {id}");
                case "404": return View("NotFound");
            }
        }

        public IActionResult ContactUs() => View();
    }
}
