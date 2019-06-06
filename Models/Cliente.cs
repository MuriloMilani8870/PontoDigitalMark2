using System;

namespace PontoDigitalMark2.Models
{
    public class Cliente
    {
        public ulong id {get;set;}
        public ulong ID { get; internal set; }
        public string Nome {get;set;}

        public string CPF{get;set;}

        public string Email{get;set;}
        public DateTime DataNascimento { get; internal set; }
        public string Senha { get; internal set; }
    }
}