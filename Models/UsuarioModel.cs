using System;

namespace PontoDigitalMark2.Models
{
    public class UsuarioModel
    {
        public int ID {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
        public bool Admin {get;set;}

        public UsuarioModel(){
        }

        public UsuarioModel(string nome, string email, string senha, DateTime dataNascimento){
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
            this.Admin = false;
        }
    }
}