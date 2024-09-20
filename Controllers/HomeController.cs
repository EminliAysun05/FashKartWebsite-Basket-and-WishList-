using FashKartWebsite.DataAccesLayer;
using FashKartWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FashKartWebsite.Controllers
{
    public class HomeController : Controller
    {
        //databasein contentini inject edirem
        private readonly AppDbContext _dbContext;

      

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.ToList();

            var model = new HomeViewModel()
            {
                Categories = categories,
                Products = products
               
            };
            return View(model);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
