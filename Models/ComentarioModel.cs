using System;

namespace PontoDigitalMark2.Models
{
    public class ComentarioModel
    {
        public int ID {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Texto {get;set;}
        public DateTime Data {get;set;}
        public bool Aprovado {get;set;}

        public ComentarioModel(){
            this.Aprovado = false;
        }
        public ComentarioModel(string nome, string email, string texto){
            this.Aprovado = false;
            this.Nome = nome;
            this.Email = email;
            this.Texto = texto;
        }

    }
}