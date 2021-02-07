using findRes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace findRes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Declaring the variable
            List<string> resList;
            // Create a new list of string type using the variable above
            resList = new List<string>();

            foreach (topRes i in topRes.GetTopRes())
            {
                int? Rank = i.rank;
                string? Fav = i.favDish ?? "It's all tasty!";
                string? Web = i.webLink ?? "Coming soon.";
                resList.Add($"#{Rank}: | {i.resName} | {Fav} | {i.address} | {i.phone} | {Web}");
            }

            return View(resList);
        }
        
        [HttpGet]
        public IActionResult dataInput()
        {
            return View();
        }

        [HttpPost]
        public IActionResult dataInput(cusFavRes data)
        {
            if (!ModelState.IsValid)
            {
                return View("dataInput");
            }
            TempStorage.AddApplication(data);
            return View("Confirm", data);
        }

        public IActionResult db()
        {
            return View(TempStorage.Applications);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
