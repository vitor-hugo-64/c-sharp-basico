using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.biblioteca
{
    class Veiculo
    {
        public string marca;
        public string modelo;
        public string ano;

        public virtual void mover() // virtual - PALAVRA USADA PARA INFORMAR QUE O METODO ESPECIFICO PODE SER SOBRESCRITO
        {
            Console.WriteLine("Mover Chamado Dentro De Veiculo!");
        }
    }
}
