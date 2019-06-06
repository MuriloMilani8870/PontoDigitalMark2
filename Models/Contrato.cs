using System;

namespace PontoDigitalMark2.Models
{
    public class Contrato
    {
        public ulong id {get;set;}
        public ulong ID { get; internal set; }
        public Cliente Cliente {get;set;}

        public Plano Plano {get;set;}

        public DateTime DataPedido{get;set;}

        public double Preco{get;set;}
        public DateTime DataDoContrato { get; internal set; }
    }
}