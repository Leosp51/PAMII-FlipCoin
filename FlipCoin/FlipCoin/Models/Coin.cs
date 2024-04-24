using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin.Models
{
    internal class Coin
    {
        //Propriedade -> escrever Prop, enter a alterar o tipo e o nome do campo
        public string Lado { get; set; }

        public string Jogar() {
            int ladoSorteado = new Random().Next(2);
            //0 é cara e 1 é coroa
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            return (Lado);
        }

        public string Jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            //0 é cara e 1 é coroa
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            string resultado = ladoEscolhido == Lado ? 
                $"Parabens, você pediu {ladoEscolhido} e deu {Lado}" :
                $"Que pena, você pedu {ladoEscolhido} e deu {Lado}";
            return (resultado);
        }

    }
}
