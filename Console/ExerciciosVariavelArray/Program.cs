using System;

namespace ExerciciosVariavelArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** EXERCÍCIO 1 *** //

            string nome, idadeTexto;
            int anoNascimento;

            Console.WriteLine("Informe Seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe Sua Idade: ");
            idadeTexto = Console.ReadLine();

            // DateTime.Now.Year - Serve Para Pegar O Ano Atual
            anoNascimento = (DateTime.Now.Year) - short.Parse(idadeTexto);

            Console.WriteLine(nome + " Você Nasceu No Ano De " + anoNascimento);

            Console.ReadKey();
        }
    }
}
