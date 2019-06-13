using System;
using Microsoft.Extensions.Primitives;

namespace PontoDigitalMark2.Models
{
    public class Depoimento : Relato
    {
        public int Id{get;set;}

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
    }
}