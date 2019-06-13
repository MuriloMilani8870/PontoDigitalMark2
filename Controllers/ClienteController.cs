using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;
using PontoDigitalMark2.ViewModels;

namespace PontoDigitalMark2.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();

        ContratoViewModel contratoviewmodel = new ContratoViewModel();
        private const string SESSION_EMAIL = "_EMAIL";

        private const string SESSION_CLIENTE = "_CLIENTE";

        [HttpGet]
        public IActionResult Login(){
            return View();
        }

        public IActionResult Depoimento(){
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(IFormCollection form){
            Depoimento depoimento = new Depoimento();
            depoimento.Nome = form["nome"];
            depoimento.Depoimento = form["depoimento"];

            depoimentoRepositorio.InserirNoCSV(depoimento);

            ViewData["Controller"] = "Depoimento";
            return View("Sucesso");
        }

        

        [HttpPost]
        public IActionResult Login(IFormCollection form){
            var usuario = form ["email"];
            var senha = form["senha"];

            var cliente = clienteRepositorio.ObterPor(usuario);

            if (cliente != null && cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
            }
            return RedirectToAction("Index" , "Home");
        }

        [HttpGet]
        public IActionResult Logout(){
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index" , "Home");

        }

         public IActionResult Listar(){
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
            ViewData["depoimentos"] = depoimentoRepositorio.Listar();
            return View();
        }

    }
}