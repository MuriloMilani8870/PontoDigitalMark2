using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class DepoimentoRepositorio
    {
        private const string PATH = "DataBase/Depoimento.csv";
        public Depoimento Adicionar(Depoimento depoimento)
        {
            if (!File.Exists(PATH))
            {
                depoimento.Id = 1;
                File.Create(PATH).Close();
            }
            else
            {
                depoimento.Id = File.ReadAllLines(PATH).Length + 1;
            }
            depoimento.Data = DateTime.Now;
            depoimento.Texto.Replace("\n", " ");

            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{depoimento.Id};{depoimento.Nome};{depoimento.Email};{depoimento.Texto};{depoimento.Data};{depoimento.Aprovado}");
            sw.Close();

            return depoimento;
        }

        private List<Depoimento> listaDeDepoimentos = new List<Depoimento>();
        public List<Depoimento> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                var depoimento = new Depoimento();

                depoimento.Id = int.Parse(dados[0]);
                depoimento.Nome = dados[0];
                depoimento.Depoimento = dados[1];
                depoimento.DataDepoimento = DateTime.Parse(dados[2]);

                listaDeDepoimentos.Add(depoimento);

            }
            return (listaDeDepoimentos);
        }

        public void Deletar(Depoimento depoimento)
        {
            string[] linhas = File.ReadAllLines(PATH);
            List<string> linesList = File.ReadAllLines(PATH).ToList();


            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (depoimento.Id.ToString() == linha[0])
                {

                    linesList.RemoveAt(i);
                    break;
                }
            }
            File.WriteAllLines(PATH, linesList.ToArray());

        }


        public List<Depoimento> ListarAprovados()
        {
            List<Depoimento> listaDedepoimentos = new List<Depoimento>();

            string[] linhas = File.ReadAllLines(PATH);

            for (int i = linhas.Length; i > 0; i--)
            {

                if (linhas[i - 1] != null)
                {
                    string[] dados = linhas[i - 1].Split(";");

                    if (bool.Parse(dados[5]))
                    {
                        var depoimento = new Depoimento();
                        depoimento.Id = int.Parse(dados[0]);
                        depoimento.Nome = dados[1];
                        depoimento.Email = dados[2];
                        depoimento.Texto = dados[3];
                        depoimento.Data = DateTime.Parse(dados[4]);
                        depoimento.Aprovado = bool.Parse(dados[5]);

                        listaDedepoimentos.Add(depoimento);
                    }
                    continue;
                }
            }
            return listaDedepoimentos;
        }

        public List<Depoimento> ListarReprovados()
        {
            List<Depoimento> listaDedepoimentos = new List<Depoimento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (item != null)
                {
                    string[] dados = item.Split(";");

                    if (!bool.Parse(dados[5]))
                    {
                        var depoimento = new Depoimento();
                        depoimento.Id = int.Parse(dados[0]);
                        depoimento.Nome = dados[1];
                        depoimento.Email = dados[2];
                        depoimento.Texto = dados[3];
                        depoimento.Data = DateTime.Parse(dados[4]);
                        depoimento.Aprovado = bool.Parse(dados[5]);

                        listaDedepoimentos.Add(depoimento);
                    }
                    continue;
                }
            }
            return listaDedepoimentos;
        }

        public Depoimento BuscarPorId(int Id)
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                if (Id.ToString().Equals(linha[0]))
                {
                    Depoimento depoimento = new Depoimento();
                    depoimento.Id = int.Parse(linha[0]);
                    depoimento.Nome = linha[1];
                    depoimento.Email = linha[2];
                    depoimento.Texto = linha[3];
                    depoimento.Data = DateTime.Parse(linha[4]);
                    depoimento.Aprovado = bool.Parse(linha[5]);

                    return depoimento;
                }

            }
            return null;
        }

        public void Editar(Depoimento depoimento)
        {
            string[] linhas = File.ReadAllLines(PATH);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (depoimento.Id.ToString() == linha[0])
                {
                    linhas[i] = $"{depoimento.Id};{depoimento.Nome};{depoimento.Email};{depoimento.Texto};{depoimento.Data};{depoimento.Aprovado}";
                    break;
                }
            }
            File.WriteAllLines(PATH, linhas);

        }
    }
}