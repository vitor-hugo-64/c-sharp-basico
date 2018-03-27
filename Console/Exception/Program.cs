using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe Um Número: ");

            try // ESSA PARTE TENTA EXECUTAR O CÓDIGO DO ESCOPO
            {
                int numero = int.Parse(Console.ReadLine());
            } catch (FormatException e) // EXECUTA CASO ALCONTEÇA ERRO
            {
                Console.WriteLine("Erro!");
            } finally // SEMPRE EXECUTA, MESMO SE DER ERRO OU NÃO
            {
                Console.WriteLine("Finalmemte!");
            }

            Console.ReadKey();
        }
    }
}
