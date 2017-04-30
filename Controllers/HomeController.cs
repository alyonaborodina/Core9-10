using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core9.Models;
using Microsoft.EntityFrameworkCore;

namespace Core9.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext _context;
        public HomeController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }
        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew (Product _product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(_product);
                _context.SaveChanges();
                return Redirect("Index");
            }
            return View();
        }

        public IActionResult Delete(int _id)
        {
            Product data = _context.Product.FirstOrDefault(x => x.Id == _id);
            if (data != null)
            {
                _context.Product.Remove(data);
                _context.SaveChanges();
            }
            return Redirect("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
