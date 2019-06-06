using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovoPontoDigital.Models;

namespace NovoPontoDigital.Controllers {
    public class HomeController : Controller {

        private const string SESSION_EMAIL = "_EMAIL";

        private const string SESSION_CLIENTE = "_CLIENTE";
        public IActionResult Index () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_CLIENTE);
            ViewData["NomeView"] = "Home";
            return View ();
        }

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";

            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}