using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;
using PontoDigitalMark2.ViewModels;

namespace PontoDigitalMark2.Controllers
{
    public class DepoimentoController : Controller{
         private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        public IActionResult Index(){
            ViewData["UserNome"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["UserEmail"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["Css"] = "Comentarios";
            ViewData["Title"] = "Comentarios";
            DepoimentosViewModel comentarioViewModel = new DepoimentosViewModel();

            return View(comentarioViewModel);
        }

        public IActionResult Comentar(IFormCollection form){
            var username = HttpContext.Session.GetString("USER_NOME");
            var useremail = HttpContext.Session.GetString("USER_EMAIL");
            var text = form["msg"];

            System.Console.WriteLine($"{username}\n{useremail}\n{text}\n\n\n");
            Depoimento depoimento = new Depoimento(username,useremail,text);

            depoimentoRepositorio.Adicionar(depoimento);

            return RedirectToAction("Index");
        }
    }
}