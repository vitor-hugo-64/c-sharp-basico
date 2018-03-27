using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.biblioteca.derivada
{
    class Carro : Veiculo
    {
        public override void mover() // override - PALAVRA USADA PARA INFORMAR QUE O METODO DA CLASSE PAI ESTÁ SENDO SOBRESCRITO PELO METODO ESPECIFICO
        {
            Console.WriteLine("Mover Chamado Dentro De Carro!");
        }
    }
}
