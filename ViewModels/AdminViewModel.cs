using System.Collections.Generic;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.ViewModels
{
    public class AdminViewModel
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
        public List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public List<ComentarioModel> listaDeReprovados = new List<ComentarioModel>();

        public UsuarioModel UsuarioRecuperado;
        public int QuantidadeDeComentarios;
        public int QuantidadeDeAprovados;
        public int QuantidadeDeReprovados;
        public int QuantidadeDeUsuarios;
        
        public AdminViewModel(){
            listaDeComentarios = comentarioRepositorio.Listar(); 
            listaDeUsuarios = usuarioRepositorio.Listar();    
            QuantidadeDeComentarios = listaDeComentarios.Count;

            QuantidadeDeUsuarios = listaDeUsuarios.Count;
            List<ComentarioModel> listaDeAprovados = new List<ComentarioModel>();
            listaDeAprovados = comentarioRepositorio.ListarAprovados();
            QuantidadeDeAprovados = listaDeAprovados.Count;
            
            listaDeReprovados = comentarioRepositorio.ListarReprovados();
            QuantidadeDeReprovados = listaDeReprovados.Count;
        }
    
        public AdminViewModel(UsuarioModel usuarioRecuperado){
            listaDeComentarios = comentarioRepositorio.Listar(); 
            listaDeUsuarios = usuarioRepositorio.Listar();    
            QuantidadeDeComentarios = listaDeComentarios.Count;

            QuantidadeDeUsuarios = listaDeUsuarios.Count;
            List<ComentarioModel> listaDeAprovados = new List<ComentarioModel>();
            listaDeAprovados = comentarioRepositorio.ListarAprovados();
            QuantidadeDeAprovados = listaDeAprovados.Count;
            
            listaDeReprovados = comentarioRepositorio.ListarReprovados();
            QuantidadeDeReprovados = listaDeReprovados.Count;

            this.UsuarioRecuperado = usuarioRecuperado;
        }            


    }
}