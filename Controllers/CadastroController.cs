
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
         public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form){
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepositorio.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}