using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;
using PontoDigitalMark2.ViewModels;

namespace PontoDigitalMark2.Controllers
{
    public class AdminController: Controller
    {
        public IActionResult Index(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Admin";
            
            if (ViewData["UserA"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();
                    
                    return View(adminViewModel);
                }
            }

            return RedirectToAction("Index","Home");      
        }

        public IActionResult Comentarios(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Comentarios";
            
            if (ViewData["UserA"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();
            
                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index","Home");      
        }
        public IActionResult Usuarios(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Usuarios";
            
            
            if (ViewData["UserA"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();
            
                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index","Home");      
        }

        

        public IActionResult Aprovar(int id){
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            
            if (ViewData["UserA"] == null)
            {
                return RedirectToAction("Index","Home");
            }


            System.Console.WriteLine(id);
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioModel comentario = comentarioRepositorio.BuscarPorId(id);
                
            if (comentario.Aprovado){
                comentario.Aprovado = false;
            }else{
                comentario.Aprovado = true;
            }

            comentarioRepositorio.Editar(comentario);

            return RedirectToAction("Comentarios");
        }
        public IActionResult Deletar(int id){
            System.Console.WriteLine(id);
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioModel comentario = comentarioRepositorio.BuscarPorId(id);

            comentarioRepositorio.Deletar(comentario);

            return RedirectToAction("Comentarios");
        }

        public IActionResult DeletarUser(int id){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.BuscarPorId(id);

            usuarioRepositorio.Deletar(usuario);

            return RedirectToAction("Usuarios");
        }

        public IActionResult Editar(int id){

            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Editar";
            
            
            if (ViewData["UserA"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
                    UsuarioModel usuarioRecuperado = usuarioRepositorio.BuscarPorId(id);

                    AdminViewModel adminViewModel = new AdminViewModel(usuarioRecuperado);
            
                    return View(adminViewModel);
                }
            }
            return RedirectToAction("Index","Home");      
        }

        public IActionResult EditarUser(IFormCollection form){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.BuscarPorId(int.Parse(form["id"]));

            if (usuario == null){
                ViewData["Mensagem"] = "Ocorreu um erro durante a edição de usuario";    
                return RedirectToAction("Usuarios");
            }

            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];

            usuarioRepositorio.Editar(usuario);


            return RedirectToAction("Usuarios");
        }

    }
}