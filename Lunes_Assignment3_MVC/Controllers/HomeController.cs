using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lunes_Assignment3_MVC.Models;
using Microsoft.Extensions.Localization;

namespace Lunes_Assignment3_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }


        public IActionResult Index()
        {
            ViewData["WelcomeTitle"] = _localizer["Welcome to my transaction tracking application"];
            ViewData["Welcome1"] = _localizer["This is an assignment project. To go to the Transactions page click the money logo on the upper right corner of the page"];
            ViewData["WelcomeTech"] = _localizer["Technologies Used"];
            ViewData["Title"] = _localizer["Transaction Tracking App"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
