using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // A CLASSE LIST SERVE PRA ARMAZENAR EM QUANTIDADE INFINITA ELEMENTOS DE UM ÚNICO TIPO

            // ESSA É A FORMA QUE SE DECLARA
            List<string> marcas = new List<string>();

            // ADICIONA ELEMENTOS A LISTA
            marcas.Add("FIAT");
            marcas.Add("Chevrolet");
            marcas.Add("Renault");
            marcas.Add("Pegeaout");
            marcas.Add("Volkswagen");

            // ACESSANDO OS ELEMTOS DA LISTA

            // ACESSA UM ÚNICO ELEMENTO
            Console.WriteLine(marcas[0]);

            // TAMBÉM PODE SER USADO O FOREACH
            foreach(string nome in marcas)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();


        }
    }
}
