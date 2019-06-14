using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;
using PontoDigitalMark2.ViewModels;

namespace PontoDigitalMark2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["UserNome"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserEmail"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Admin";

            if (ViewData["UserAdmin"] != null)
            {
                if (bool.Parse((string)ViewData["UserAdmin"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();

                    return View(adminViewModel);
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Comentarios()
        {
            ViewData["UserNome"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserEmail"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Comentarios";

            if (ViewData["UserAdm"] != null)
            {
                if (bool.Parse((string)ViewData["UserAdm"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();

                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Usuarios()
        {
            ViewData["UserNome"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserEmail"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Usuarios";


            if (ViewData["UserAdm"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();

                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Aprovar(int id)
        {
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");

            if (ViewData["UserAdm"] == null)
            {
                return RedirectToAction("Index", "Home");
            }


            System.Console.WriteLine(id);
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
            Depoimento depoimento = depoimentoRepositorio.BuscarPorId(id);

            if (depoimento.Aprovado)
            {
                depoimento.Aprovado = false;
            }
            else
            {
                depoimento.Aprovado = true;
            }

            depoimentoRepositorio.Editar(depoimento);

            return RedirectToAction("Comentarios");
        }
        public IActionResult Deletar(int id)
        {
            System.Console.WriteLine(id);
            DepoimentoRepositorio comentarioRepositorio = new DepoimentoRepositorio();
            Depoimento comentario = comentarioRepositorio.BuscarPorId(id);

            comentarioRepositorio.Deletar(comentario);

            return RedirectToAction("Comentarios");
        }

        public IActionResult DeletarUser(int id)
        {
            DepoimentoRepositorio usuarioRepositorio = new DepoimentoRepositorio();
            Depoimento usuario = usuarioRepositorio.BuscarPorId(id);

            usuarioRepositorio.Deletar(usuario);

            return RedirectToAction("Usuarios");
        }

        public IActionResult Editar(int id)
        {

            ViewData["UserNome"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserEmail"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserAdm"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Editar";


            if (ViewData["UserAdm"] != null)
            {
                if (bool.Parse((string)ViewData["UserAdm"]))
                {
                    ClienteRepositorio usuarioRepositorio = new ClienteRepositorio();
                    Cliente usuarioRecuperado = usuarioRepositorio.BuscarPorId(id);

                    AdminViewModel adminViewModel = new AdminViewModel(usuarioRecuperado);

                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditarUser(IFormCollection form)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente usuario = clienteRepositorio.BuscarPorId(int.Parse(form["id"]));

            if (usuario == null)
            {
                ViewData["Mensagem"] = "Ocorreu um erro durante a edição de usuario";
                return RedirectToAction("Usuarios");
            }

            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];

            clienteRepositorio.Editar(usuario);


            return RedirectToAction("Usuarios");
        }
    }

}