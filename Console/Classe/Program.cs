using System;
using classes.Carro; // DESSA FORMA SE USA O NAMESPACE

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIA OBJETOS
            Carro carro = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            // PRINTA NA TELA A MARCA DO CARRO
            Console.WriteLine(carro.Marca);

            // ATRIBUI UM NOVO VALOR
            carro.Marca = "Ford";

            // PRINTA
            Console.WriteLine(carro.Marca);

            // PRINTA
            Console.WriteLine("Luzes Internas: " + carro2.luzesInternas);
            carro2.abrirPorta();
            Console.WriteLine("Luzes Internas: " + carro2.luzesInternas);

            // ARMAZENA OS DADOS RETORNADOS NA FUNÇÃO DENTRO DE UMA VARIÁVEL
            string statusFarol = carro2.acenderFarolAutomaticamente();
            Console.WriteLine(statusFarol);

            Console.ReadKey();
        }
    }
}
