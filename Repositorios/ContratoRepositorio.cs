using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class ContratoRepositorio : BaseRepositorio
    {
         public static uint CONT = 0;
        private const string PATH = "Database/Pedido.csv";
        private const string PATH_INDEX = "Database/Pedido_Id.csv";
        private List<Contrato> pedidos = new List<Contrato> ();

        public ContratoRepositorio() {
            if (!File.Exists(PATH_INDEX))
            {
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir (Contrato contrato) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (contrato);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar (Contrato contrato) {
            var pedidosRecuperados = ObterRegistrosCSV (PATH);
            var clienteString = PrepararRegistroCSV (contrato);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++) {
                if (clienteString.Equals (pedidosRecuperados[i])) {
                    linhaPedido = i;
                    resultado = true;
                }
            }
            if (linhaPedido >= 0) {
                pedidosRecuperados[linhaPedido] = clienteString;
                File.WriteAllLines (PATH, pedidosRecuperados);
            }

            return resultado;

        }

        public bool Apagar (ulong id) {

            var pedidosRecuperados = ObterRegistrosCSV (PATH);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++) {
                if (id.Equals (pedidosRecuperados[i])) {
                    linhaPedido = i;
                    resultado = true;
                }
            }

            if (linhaPedido >= 0) {
                pedidosRecuperados[linhaPedido] = "";
                File.WriteAllLines (PATH, pedidosRecuperados);
            }

            return resultado;
        }

        public Contrato ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString(), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public Contrato ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (email.Equals (ExtrairCampo (email, item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public List<Contrato> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Contrato contrato = ConverterEmObjeto (item);

                this.pedidos.Add (contrato);
            }
            return this.pedidos;
        }

        public List<Contrato> ListarTodosPorCliente (string nomeCliente) {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {
                Contrato contrato = ConverterEmObjeto (item);
                if (contrato.Cliente.Nome.Equals(nomeCliente))
                {
                    this.pedidos.Add (contrato);
                }
            }
            return this.pedidos;
        }

        private Contrato ConverterEmObjeto(string registro)
        {
            Contrato pedido = new Contrato();
            pedido.ID = ulong.Parse(ExtrairCampo("id", registro));
            pedido.Cliente.Nome = ExtrairCampo("clienteNome", registro);
            pedido.Cliente.Email = ExtrairCampo("clienteEmail", registro);
            pedido.Plano.Nome = ExtrairCampo("hamburguerNome", registro);
            pedido.Plano.Preco = double.Parse(ExtrairCampo("hamburguerPreco", registro));
            pedido.DataPedido = DateTime.Parse(ExtrairCampo("dataPedido", registro));
            pedido.Preco = double.Parse(ExtrairCampo("precoTotal", registro));
            
            return pedido;
        }

        private string PrepararRegistroCSV(Contrato contrato)
        {
            ulong id = contrato.ID == 0 ? CONT : contrato.ID;
            return $"id={id};clienteNome={contrato.Cliente.Nome}clienteEmail={contrato.Cliente.Email};planoNome={contrato.Plano.Nome};planoPreco={contrato.Plano.Preco};dataContrato={contrato.DataDoContrato};preco={contrato.Preco}\n";
        }
    }
}