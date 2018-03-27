using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga
{
    class Pessoa
    {
        public int andar() // AQUI FICA UM METODO SIMPLES
        {
            return 1;
        }

        public int andar(int num) // METODO COM O MESMO NOME PORÉM POSSUI PARAMETROS, ENTÃO ACONTECE UMA SOBRECARGA
        {
            return num;
        }
    }
}
