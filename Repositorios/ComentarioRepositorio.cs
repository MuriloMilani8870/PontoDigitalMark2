using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class ComentarioRepositorio
    {
        private const string PATH = "Database/Comentario.csv";
        private List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();

        public ComentarioModel Inserir(ComentarioModel comentario){
            if (!File.Exists(PATH)){
                comentario.ID = 1;
                File.Create(PATH).Close();
            }else{
                comentario.ID= File.ReadAllLines(PATH).Length + 1;
            }
            comentario.Data = DateTime.Now;
            comentario.Texto.Replace("\n"," ");
            
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{comentario.ID};{comentario.Nome};{comentario.Email};{comentario.Texto};{comentario.Data};{comentario.Aprovado}");
            sw.Close();

            return comentario;
        }

        public List<ComentarioModel> Listar(){
            List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();

            string[] linhas = File.ReadAllLines(PATH);

            // foreach (var item in linhas){
            //     if (item != null && !item.Equals("")){
            //         string[] dados = item.Split(";");

            //         var comentario = new ComentarioModel();
            //         comentario.ID = int.Parse(dados[0]);
            //         comentario.Nome = dados[1];
            //         comentario.Email = dados[2];
            //         comentario.Texto = dados[3];
            //         comentario.Data = DateTime.Parse(dados[4]);
            //         comentario.Aprovado = bool.Parse(dados[5]);


            //         listaDeComentarios.Add(comentario);
            //     }
            // }
            // return listaDeComentarios;

            for (int i = linhas.Length; i > 0; i--){  //LISTAGEM DO MAIS NOVO PRO MAIS ANTIGO
                
                if (linhas[i-1] != null){
                    string[] dados = linhas[i-1].Split(";");

                        var comentario = new ComentarioModel();
                        comentario.ID = int.Parse(dados[0]);
                        comentario.Nome = dados[1];
                        comentario.Email = dados[2];
                        comentario.Texto = dados[3];
                        comentario.Data = DateTime.Parse(dados[4]);
                        comentario.Aprovado = bool.Parse(dados[5]);

                        listaDeComentarios.Add(comentario);

                    continue;   
                }
            }
            return listaDeComentarios;

        }

        public void Editar(ComentarioModel comentario)
        {
            string[] linhas = File.ReadAllLines(PATH);
                
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (comentario.ID.ToString() == linha[0]){
                    linhas[i] = $"{comentario.ID};{comentario.Nome};{comentario.Email};{comentario.Texto};{comentario.Data};{comentario.Aprovado}";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);

        }

        public void Deletar(ComentarioModel comentario){
            string[] linhas = File.ReadAllLines(PATH);
            List<string> linesList = File.ReadAllLines(PATH).ToList();
            

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (comentario.ID.ToString() == linha[0]){

                    linesList.RemoveAt(i);
                    break;
                }
            }
            File.WriteAllLines(PATH,linesList.ToArray());

        }

        public List<ComentarioModel> ListarAprovados(){
            List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();

            string[] linhas = File.ReadAllLines(PATH);

            // foreach (var item in linhas){  //LISTAGEM DO MAIS ANTIGO PRO MAIS NOVO
            //     if (item != null){
            //         string[] dados = item.Split(";");
            //         if (bool.Parse(dados[5]))
            //         {
            //             var comentario = new ComentarioModel();
            //             comentario.ID = int.Parse(dados[0]);
            //             comentario.Nome = dados[1];
            //             comentario.Email = dados[2];
            //             comentario.Texto = dados[3];
            //             comentario.Data = DateTime.Parse(dados[4]);
            //             comentario.Aprovado = bool.Parse(dados[5]);
            //             listaDeComentarios.Add(comentario);
            //         }
            //         continue;   
            //     }
            // }

            for (int i = linhas.Length; i > 0; i--){  //LISTAGEM DO MAIS NOVO PRO MAIS ANTIGO
                
                if (linhas[i-1] != null){
                    string[] dados = linhas[i-1].Split(";");

                    if (bool.Parse(dados[5]))
                    {
                        var comentario = new ComentarioModel();
                        comentario.ID = int.Parse(dados[0]);
                        comentario.Nome = dados[1];
                        comentario.Email = dados[2];
                        comentario.Texto = dados[3];
                        comentario.Data = DateTime.Parse(dados[4]);
                        comentario.Aprovado = bool.Parse(dados[5]);

                        listaDeComentarios.Add(comentario);
                    }
                    continue;   
                }
            }
            return listaDeComentarios;
        }
           
        public List<ComentarioModel> ListarReprovados(){
            List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas){
                if (item != null){
                    string[] dados = item.Split(";");

                    if (!bool.Parse(dados[5]))
                    {
                        var comentario = new ComentarioModel();
                        comentario.ID = int.Parse(dados[0]);
                        comentario.Nome = dados[1];
                        comentario.Email = dados[2];
                        comentario.Texto = dados[3];
                        comentario.Data = DateTime.Parse(dados[4]);
                        comentario.Aprovado = bool.Parse(dados[5]);

                        listaDeComentarios.Add(comentario);
                    }
                    continue;   
                }
            }
            return listaDeComentarios;
        }

        public ComentarioModel BuscarPorId(int id){
            string[] linhas = File.ReadAllLines(PATH);
            
            foreach (var item in linhas){
                string[] linha = item.Split(";");

                if (id.ToString().Equals(linha[0])){
                    ComentarioModel comentario = new ComentarioModel();
                    comentario.ID = int.Parse(linha[0]);
                    comentario.Nome = linha[1];
                    comentario.Email = linha[2];
                    comentario.Texto = linha[3];
                    comentario.Data = DateTime.Parse(linha[4]);
                    comentario.Aprovado = bool.Parse(linha[5]);

                    return comentario;
                }

            }
            return null;      
        }

    }
}