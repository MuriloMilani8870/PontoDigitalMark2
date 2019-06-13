using System.Collections.Generic;
using PontoDigitalMark2.Models;

namespace PontoDigitalMark2.ViewModels
{
    public class ContratoViewModel
    {
        public List<Plano> Planos {get;set;}

        public Cliente Cliente {get;set;}

        public List<Depoimento> Depoimentos {get;set;}
    }
}