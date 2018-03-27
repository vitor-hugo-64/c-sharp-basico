using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrescrita.biblioteca
{
    class Carro : Veiculo
    {
        public int rodas = 4;

        public void mover() // SOBRESCREVE O METODO DA CLASSE PAI
        {
            Console.WriteLine("Mover Chamado Dentro De Carro.mover");
            base.mover(); // ISSO EXECUTA O METODO DA CLASSE PAI
        }
    }
}
