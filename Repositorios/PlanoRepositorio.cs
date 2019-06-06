using System.Collections.Generic;
using System.IO;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class PlanoRepositorio
    {
        private const string PATH = "Database/Hamburguer.csv";

        private List<Plano> Planos = new List<Plano> ();

        public List<Plano> Listar () {

            var registros = File.ReadAllLines (PATH);
            foreach (var item in registros) {
                var valores = item.Split (";");
                Plano plano = new Plano ();
                plano.Nome = valores[1];
                plano.Preco = double.Parse (valores[2]);

                this.Planos.Add (plano);

            }

            return this.Planos;
        }

        public double ObterPrecoDe (string nomePlano) {
            var lista = Listar ();
            var preco = 0.0;

            foreach (var item in lista) {
                if (item.Nome.Equals(nomePlano)) {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    }
}