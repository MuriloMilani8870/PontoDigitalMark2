using System;

namespace PontoDigitalMark2.Models
{
    public class Cliente
    {
        public ulong ID { get; internal set; }
        public string Nome {get;set;}

        public string Email{get;set;}
        public DateTime DataNascimento { get; internal set; }
        public string Senha { get; internal set; }

        public bool Admin {get;set;}
    }
}