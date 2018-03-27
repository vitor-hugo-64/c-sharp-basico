using System;
using System.Collections.Generic;
using System.Text;

namespace Construtor
{
    /// <summary>
    /// CLASSE DE CARRO FEITA PELO VITOR
    /// </summary>
    class Carro
    {
        public string marca;
        public string modelo;

        // DESSA FORMA SE PROGRAMA UM CONSTRUTOR
        public Carro()
        {
            this.marca = "FIAT";
            this.modelo = "Palio";
        }

        // PODE SER SOBRESCRITO TAMBÉM, PARA QUE SEJA INFORMADO OS PARAMETROS INICIAIS LOGO DE INICIO
        public Carro( string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}
