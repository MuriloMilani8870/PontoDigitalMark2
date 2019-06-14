using System.Collections.Generic;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.ViewModels
{
    public class DepoimentosViewModel
    {
        public List<Depoimento> listaDeComentarios = new List<Depoimento>();
        private DepoimentoRepositorio comentarioRepositorio = new DepoimentoRepositorio();
        public DepoimentosViewModel(){
            listaDeComentarios = comentarioRepositorio.ListarAprovados();
        }
    }
}