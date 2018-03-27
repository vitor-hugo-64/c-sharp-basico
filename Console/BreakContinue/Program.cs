using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONTINUE
            Console.WriteLine("CONTINUE");
            for(int x = 1; x < 10; x++)
            {
                if(x == 5)
                {
                    continue; // IRA PULAR O LOOP ATUAL  IRÁ PARA O PRÓXIMO
                }
                Console.WriteLine(x);
            }

            Console.WriteLine("");
            Console.WriteLine("BREAK");
            for (int x = 1; x < 10; x++)
            {
                if (x == 5)
                {
                    break; // IRÁ PARAR O LAÇO DE REPETIÇÃO INTEIRO
                }
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
