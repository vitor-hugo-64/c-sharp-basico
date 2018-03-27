using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrescrita.biblioteca
{
    class Moto : Veiculo
    {
        public int rodas = 2;

        public void mover() // SOBRESCREVE O METODO DA CLASSE PAI
        {
            Console.WriteLine("Mover Chamado Dentro De Moto.mover");
            base.mover(); // ISSO EXECUTA O METODO DA CLASSE PAI
        }

    }
}
