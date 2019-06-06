using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;
using PontoDigitalMark2.ViewModels;

namespace PontoDigitalMark2.Controllers
{
    public class ContratoController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";

        private const string SESSION_CLIENTE = "_CLIENTE";

        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        ContratoRepositorio contratoRepositorio = new ContratoRepositorio();
        
        PlanoRepositorio PlanoRepositorio = new PlanoRepositorio();
        
        [HttpGet]
        public IActionResult Index () {

            var hamburgueres = PlanoRepositorio.Listar();
            var cliente = clienteRepositorio.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));

            ContratoViewModel pedido = new ContratoViewModel();
            pedido.Planos = hamburgueres;
            pedido.Cliente = cliente == null ? new Cliente(): cliente;
            return View (pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido (IFormCollection form) {
            System.Console.WriteLine (form["nome"]);
            System.Console.WriteLine (form["endereco"]);
            System.Console.WriteLine (form["telefone"]);
            System.Console.WriteLine (form["email"]);
            System.Console.WriteLine (form["hamburguer"]);
            System.Console.WriteLine (form["shake"]);

            Contrato contrato = new Contrato();

            //Instanciação de objeto - Forma 1
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];

            contrato.Cliente = cliente;

            //Instanciação de objeto - Forma 2 (Pede geração de construtor)

            Plano plano = new Plano(){
                Nome = form["hamburguer"],
                Preco = PlanoRepositorio.ObterPrecoDe(form["hamburguer"])
            };
            

            contrato.Plano = plano;
            //Instanciação de objeto - Forma 3
            

            contrato.Preco = contrato.Plano.Preco;
            contrato.DataPedido = DateTime.Now;

            contratoRepositorio.Inserir(contrato);

            ViewData["Controller"] = "Pedido";

            return View("Sucesso");
        }
    }
}