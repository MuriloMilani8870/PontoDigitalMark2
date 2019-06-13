using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class DepoimentoRepositorio
    {
        private const string PATH = "DataBase/Depoimento.csv";
        public void InserirNoCSV (Depoimento depoimento) {

            StreamWriter sw = new StreamWriter (PATH, true);
            sw.WriteLine($"{depoimento.Nome};{depoimento.Depoimento};{DateTime.Now}");
            sw.Close();
        }

        private List<Depoimento> listaDeDepoimentos = new List<Depoimento>();
        public List<Depoimento> Listar(){
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                var depoimento = new Depoimento();

                // depoimento.Id = int.Parse(dados[0]);
                depoimento.Nome = dados[0];
                depoimento.Depoimento = dados[1];
                depoimento.DataDepoimento = DateTime.Parse(dados[2]);

                listaDeDepoimentos.Add(depoimento);

            }
            return (listaDeDepoimentos);
        }
    }
}