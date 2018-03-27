using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // DICIONÁRIO DE DADOS SERIA UM LUGAR ONDE EXISTE UMA CHAVE DO ELEMENTO E VALOR DO ELEMENTO
            // NESSE CASO A CHAVE SERÁ EM STRING E O VALOR SERÁ INTEIRO
            Dictionary<string, int> dicionario = new Dictionary<string, int>();

            // ADICIONA O NÚMERO DA CHAVE E O VALOR DO ELEMENTO CORREPONDENTE
            dicionario.Add("Chave1", 215);
            dicionario.Add("Chave2", 475);

            // NESSE CASO VOCE PODE CHAMAR O VALOR ATRAVÉS DA CHAVE
            Console.WriteLine(dicionario["Chave1"]);

            // DICIONÁRIOS TAMBÉM ACEITAM FOR EACH

            Console.ReadKey();
        }
    }
}
