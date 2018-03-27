using System;
using Sobrescrita.biblioteca;

namespace Sobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {

            Veiculo veiculo = new Veiculo();
            Moto moto = new Moto();
            Carro carro = new Carro();

            veiculo.mover();
            carro.mover();
            moto.mover();

            Console.ReadKey();
        }
    }
}
