using System;
using Polimorfismo.biblioteca;
using Polimorfismo.biblioteca.derivada;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Onibus veiculo = new Onibus();
            moverVeiculo(veiculo); // AQUI NESSA LINHA PODE SER USADO QUALQUER DOS QUATRO OBJETOS PARA INVOCAR O METODO, JÁ QUE O METODO É FEITO A PARTIR DA CLASSE BASE
            Console.ReadKey();
        }

        // SE CRIA UM METODO COM CLASSE BASE(PAI)
        public static void moverVeiculo(Veiculo veiculo)
        {
            veiculo.mover();
        }

    }

}
