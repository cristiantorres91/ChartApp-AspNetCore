using ChartApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChartApp.Controllers
{
    public class HomeController : Controller
    {
        private List<ProductModel> products;

        public HomeController()
        {
            products = new List<ProductModel>
            {
                new ProductModel { CodeProduct = "001", Name = "TV", Price = 100,},
                new ProductModel { CodeProduct = "002", Name = "LAPTOP", Price = 500,},
                new ProductModel { CodeProduct = "001", Name = "PHONE", Price = 300,},

            };
        }

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public JsonResult GenerateChart()
        {

            return Json(products);
        }

    }
}
