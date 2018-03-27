using System;

namespace ArrayComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARA E ATRIBUI VALORES AO ARRAY
            // ESSE NÃO É O JEITO MAIS COMUM
            string[] marcasFamosas = { "Ferrari", "Google", "Coca Cola"};

            // JEITO MAIS COMUM DE SE USAR
            string[] nomes = new string[6];

            // ATRIBUI VALORES
            nomes[0] = "José";
            nomes[1] = "Maria";

            // *** ARRAY MULTIDIMENSIONAL *** //

            // CADA VIRGULA DENTRO DAS CHAVES REPRESENTA UMA DIMENSÃO A MAIS
            string[,] marcas2 = new string[3,4];

            //ATRIBUI VALORES
            marcas2[0, 0] = "Fiat";
            marcas2[0, 1] = "Chevrolet";
            marcas2[0, 2] = "Renault";
            marcas2[0, 3] = "Pegeout";

            marcas2[1, 0] = "HP";
            marcas2[1, 1] = "Dell";
            marcas2[1, 2] = "Positivo";
            marcas2[1, 3] = "CCE";

        }
    }
}
