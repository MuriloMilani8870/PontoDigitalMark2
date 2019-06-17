using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.Repositorios
{
    public class UsuarioRepositorio
    {
        private const string PATH = "Database/Usuario.csv";
        private List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public UsuarioModel Inserir(UsuarioModel usuario){
            if (!File.Exists(PATH)){
                usuario.ID = 1;
                File.Create(PATH).Close();
            }else{
                usuario.ID= File.ReadAllLines(PATH).Length + 1;
            }
            
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento.ToShortDateString()};{usuario.Admin}");
            sw.Close();

            return usuario;
        }

        public List<UsuarioModel> Listar(){
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas){
                if (item != null){
                    string[] dados = item.Split(";");

                    var usuario = new UsuarioModel();
                    usuario.ID = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataNascimento = DateTime.Parse(dados[4]);
                    usuario.Admin = bool.Parse(dados[5]);

                    listaDeUsuarios.Add(usuario);
                }
            }
            return listaDeUsuarios;
        }

        public UsuarioModel BuscarPorEmail(string email){
            List<UsuarioModel> usuarios = Listar();
            UsuarioModel usuario;

            foreach (var item in usuarios){
                if (item != null && item.Email.Equals(email)){
                    usuario = item;
                    return usuario;
                }else{
                    continue;
                }
            }
            return null;
        }

        public UsuarioModel BuscarPorId(int id){
            string[] linhas = File.ReadAllLines(PATH);
            
            foreach (var item in linhas){
                string[] dados = item.Split(";");

                if (id.ToString().Equals(dados[0])){
                    var usuario = new UsuarioModel();
                    usuario.ID = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataNascimento = DateTime.Parse(dados[4]);
                    usuario.Admin = bool.Parse(dados[5]);

                    return usuario;
                }
            }
            return null;      
        }

        public void Deletar(UsuarioModel usuario){
            string[] linhas = File.ReadAllLines(PATH);
            List<string> linesList = File.ReadAllLines(PATH).ToList();
            

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (usuario.ID.ToString() == linha[0]){

                    linesList.RemoveAt(i);
                    break;
                }
            }
            File.WriteAllLines(PATH,linesList.ToArray());
        }

        public void Editar(UsuarioModel usuario){
           string[] linhas = File.ReadAllLines(PATH);
                
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (usuario.ID.ToString() == linha[0]){
                    linhas[i] = $"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento.ToShortDateString()};{usuario.Admin}";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas); 
        }
    }
}