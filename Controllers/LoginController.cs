using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.Controllers
{
    public class LoginController: Controller
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public IActionResult Logar(IFormCollection form){
            UsuarioModel usuario = usuarioRepositorio.BuscarPorEmail(form["uname"]);
            if (usuario != null && usuario.Senha.Equals(form["psw"])){
                System.Console.WriteLine("LOGADO!");
                System.Console.WriteLine($"{usuario.ID}\n{usuario.Nome}\n{usuario.Email}\n{usuario.Senha}\n{usuario.DataNascimento.ToShortDateString()}\n{usuario.Admin}");
                HttpContext.Session.SetString("USER_NOME",usuario.Nome);
                HttpContext.Session.SetString("USER_EMAIL",usuario.Email);
                HttpContext.Session.SetString("USER_ADMIN",usuario.Admin.ToString());
            }
            if (usuario != null)
            {
                if (usuario.Admin)
                {
                    return RedirectToAction("Index","Admin");
                    
                }
            return RedirectToAction("Index","Comentarios");
            }else{

            return RedirectToAction("Index","Home");
            }

        }

        public IActionResult Logout(){
            HttpContext.Session.Remove("USER_NOME");
            HttpContext.Session.Remove("USER_EMAIL");
            HttpContext.Session.Clear();

            return RedirectToAction("Index","Home");
        }
        
    }
}