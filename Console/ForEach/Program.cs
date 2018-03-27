using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Vitor Hugo", "João", "Maria", "Pedro", "Badanha" };

            Console.WriteLine("----- REPETIÇÃO COM FOR EACH -----");

            // VAI PEGAR TODOS OS DADOS DO ARRAY E IRA ARMAZENAR CADA VALOR DELE NO LOOP DENTRO DA VARIÁVEL 'nome'
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
