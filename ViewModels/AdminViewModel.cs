using System.Collections.Generic;
using PontoDigitalMark2.Models;
using PontoDigitalMark2.Repositorios;

namespace PontoDigitalMark2.ViewModels
{
    public class AdminViewModel
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        public List<Depoimento> listaDeDepoimentos = new List<Depoimento>();
        public List<Cliente> listaDeClientes = new List<Cliente>();

        public List<Depoimento> listaDeReprovados = new List<Depoimento>();

        public Cliente UsuarioRecuperado;
        public int Depoimentos;
        public int Aprovados;
        public int Reprovados;
        public int Clientes;
        
        public AdminViewModel(){
            listaDeDepoimentos = depoimentoRepositorio.Listar(); 
            listaDeClientes = clienteRepositorio.Listar();    
            Depoimentos = listaDeDepoimentos.Count;

            Clientes = listaDeClientes.Count;
            List<Depoimento> listaDeAprovados = new List<Depoimento>();
            listaDeAprovados = depoimentoRepositorio.ListarAprovados();
            Aprovados = listaDeAprovados.Count;
            
            listaDeReprovados = depoimentoRepositorio.ListarReprovados();
            Reprovados = listaDeReprovados.Count;
        }
    
        public AdminViewModel(Cliente usuarioRecuperado){
            listaDeDepoimentos = depoimentoRepositorio.Listar(); 
            listaDeClientes = clienteRepositorio.Listar();    
            Depoimentos = listaDeDepoimentos.Count;

            Clientes = listaDeClientes.Count;
            List<Depoimento> listaDeAprovados = new List<Depoimento>();
            listaDeAprovados = depoimentoRepositorio.ListarAprovados();
            Aprovados = listaDeAprovados.Count;
            
            listaDeReprovados = depoimentoRepositorio.ListarReprovados();
            Reprovados = listaDeReprovados.Count;

            this.UsuarioRecuperado = usuarioRecuperado;
        }            
    }
}