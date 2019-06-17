using System.Collections.Generic;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.ViewModels
{
    public class ComentariosViewModel
    {
        public List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public ComentariosViewModel(){
            listaDeComentarios = comentarioRepositorio.ListarAprovados();
        }
    }
}