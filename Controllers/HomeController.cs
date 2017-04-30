using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Core9.Models.Product a)
        {
            if (ModelState.IsValid)
            {
                Core9.Models.ProductContext.Products.Add(new Models.Product()
                {
                    Name = a.Name,
                    Count = a.Count,
                    Date = a.Date
                });
                return Redirect("Index");
            }
            return View(a);
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
