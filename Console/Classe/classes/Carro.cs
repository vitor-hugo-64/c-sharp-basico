using System;
using System.Collections.Generic;
using System.Text;

namespace classes.Carro // ESTÁ EM UM NAMESPACE DIFERENTE QUE A CLASSE PRICIPAL, SERÁ NECESSÁRIO IMPORTAR
{   
    // CRIAÇÃO DA CLASSE
    class Carro
    {
        // DECLARAÇÃO DOS ATRIBUTOS
        public string Marca = "Fiat";
        string Modelo;
        string Cor;
        public bool luzesInternas = false;

        public void abrirPorta()
        {
            this.luzesInternas = true;
        }

        public void fecharPorta()
        {
            this.luzesInternas = false;
        }

        public string acenderFarolAutomaticamente()
        {
            return "Médio";
        }

    }
}
