using Microsoft.Extensions.Primitives;

namespace PontoDigitalMark2.Models
{
    public class Plano : Produto
    {
        public Plano (){

        }

        public Plano (StringValues name){
            this.Nome = Nome;
        }
    }
}