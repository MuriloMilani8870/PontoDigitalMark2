using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalMark2.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Home";
            ViewData["Title"] = "Home";
            return View();
        }
        
    }
}