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
            ViewData["WelcomeTitle"] = _localizer["WelcomeTitle"];
            ViewData["Welcome"] = _localizer["Welcome"];
            ViewData["WelcomeTech"] = _localizer["WelcomeTech"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
