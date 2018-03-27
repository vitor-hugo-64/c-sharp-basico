using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Vitor ", "Hugo ", "Balon ", "De ", "Oliveira" }; // maneira como se declara um array
            Console.WriteLine(nomes[1]); // maneira como se pega o valor de determinada posição
            nomes[3] = "DE"; // mudando o valor de determinada posição

            Console.ReadKey();
        }
    }
}
