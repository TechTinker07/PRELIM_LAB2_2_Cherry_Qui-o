using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB2_2_Cherry_Quiño.Models;

namespace PRELIM_LAB2_2_Cherry_Quiño.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var book = new Book
            {
                Id = 1,
                Title = " THIRTEEN R3ASONS WHY ",
                Author = " JAY ASHER"
            };

            var customer = new Customers
            {
                FirstName = " Cherry",
                LastName = " Quiño",
                MiddleName = " A. ",
                Title = " Ms.",
                Email = "cherry25@gmail.com"
            };

            var model = (book, customer);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
