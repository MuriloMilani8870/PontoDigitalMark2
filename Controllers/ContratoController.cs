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

            var planos = PlanoRepositorio.Listar();
            var cliente = clienteRepositorio.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));

            ContratoViewModel contrato = new ContratoViewModel();
            contrato.Planos = planos;
            contrato.Cliente = cliente == null ? new Cliente(): cliente;
            return View (contrato);
        }
    }
}