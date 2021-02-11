using Assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Controllers
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
            return View(Restaurant.GetRestaurants());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Post process when clicking submit button
        [HttpPost]
        public IActionResult Add(Restaurant onSubmit)
        {
            //Validate the inputs, do not move forward without proper data
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(onSubmit);
                return View("Confirmation", onSubmit);
            }

            return View();
        }

        public IActionResult SuggestionList()
        {
            return View(TempStorage.Applications);
        }

        public IActionResult Instructions()
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
