using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrescrita.biblioteca
{
    class Veiculo
    {
        public string marca;
        public string modelo;
        public int quatidadeMaximaPassageiros;
        public int anoFabricacao;

        public void mover()
        {
            Console.WriteLine("Mover Chamado Dentro De Veiculo.Mover");
        }
    }
}
