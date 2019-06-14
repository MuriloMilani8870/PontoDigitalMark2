using System;
using Microsoft.Extensions.Primitives;

namespace PontoDigitalMark2.Models
{
    public class Depoimento : Relato
    {
        public int Id{get;set;}

        public string Nome {get;set;}

        public string Email {get;set;}

        public string Texto {get;set;}

        public DateTime Data {get;set;}
        
        public bool Aprovado {get;set;}

        public DateTime DataDepoimento{get;set;}
        public Depoimento()
        {

        }

        public Depoimento(StringValues Nome){
            this.Nome = Nome;
        }

        public Depoimento(string Nome, string Depoimento){
            this.Nome = Nome;
            this.Depoimento = Depoimento;
        }

          public Depoimento(string nome, string email, string texto){
            this.Aprovado = false;
            this.Nome = nome;
            this.Email = email;
            this.Texto = texto;
        }
    }
}