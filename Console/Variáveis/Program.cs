using System;

namespace Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // DESSA FORMA SE CRIA USANDO APELIDO DO TIPO PRIMITIVO
            byte meuByte;

            // DESSA FORMA SE CRIA UTILIZANDO O CAMINHO DA CLASSE DESSE TIPO QUE PERTENCE AO OBJETO SYSTEM
            System.Byte meuByte2;

            // ATRIBUI O VALOR À VARIÁVEL
            meuByte = 9;

            // CRIA A VáRIÁVEL E JÁ ARMAZENA O VALOR NELA
            sbyte meuSbyte = -10;

            short meuShort = 10;

            int meuInt = 20;

            long meuLong;

            // SOMA DE VARIÁVEIS
            Console.WriteLine(meuShort + meuInt);

            // OS SEGUINTE TIPOS SÃO QUASE A MESMA COISA QUE SHORT, INT E LONG PORÉM NÃO ACEITAM NEGATIVOS
            ushort meuUshort;
            uint meuUint;
            ulong meuUlong;

            // *** TIPOS DE DADOS QUE ARMAZENAM NÚMEROS COM VÍRGULA *** //

            float meuFloat = 3.0f; // como não é double ele não tem a mesma capacidade do double então se usa o sufixo 'f' depois do número pra dizer que esse valor é float
            double meuDouble = 3.1;
            decimal meuDecimal = 3.2m; // como não é double então se usa o sufixo 'd' depois do número pra dizer que esse valor é decimal

            // *** TIPO QUE ARMAZENA TEXTO *** //

            char meuChar = 'a'; // char com aspas simples
            char meuChar2 = '!';
            string meuString = "Vitor Hugo"; // string com aspas duplas
            string meuString2 = "Hello Word!";

            Console.WriteLine(meuChar);
            Console.WriteLine(meuString);


            // *** VALORES BOLEANOS *** //

            bool meuBool = true;
            System.Boolean meuBool2 = false;


            // *** OBJETO - TIPO PRIMITIVO MAIS BÁSICO QUE É A ORIGEM DE TUDO E PODE REPRESENTAR QUALQUER OUTRO TIPO

            System.Object meuObjeto = 1;
            object meuObjeto2 = 'V';


            // *** DECLARAÇÃO DE CONSTANTES *** //

            const bool meuBool3 = true;

            // *** CONVERSÕES *** //

            string numeroTexto = "30";
            int numero = int.Parse(numeroTexto);
            int numero2 = 30;

            Console.WriteLine(numeroTexto + numero2); // isso não irá somar e sim concatenar, para somar deve se converter o 'numeroTexto' pra int
            Console.WriteLine(numero + numero2); // isso irá somar pois o número foi convertido
            Console.WriteLine("O Resultado É: " + numero + numero2); // isso não irá somar mas transformar tudo em string
            Console.WriteLine("O Resultado É: " + (numero + numero2)); // para não converter tudo em string é necessário envolver tudo em parenteses

            // *** CONVERSÕES IMPLÍCITAS *** //

            // COMO O TAMANHO SUPORTADO PODE DETERMINADAS VARIAVEIS AS VEZES É SUPORTADO ENTÃO É ACEITO QUE VARIÁVEIS DE TIPOS MENORES SEJAM POSTAS EM TIPOS MAIORES
            // como no exemplo abaixo
            short myShort = 10;
            int myInt = myShort;
            long myLong = myInt;

            // SE FOR PRA FAZER O CONTRÁRIO( COLOCAR UMA VARIAVEL QUE SUPORTE MAIS DENTRO DE UMA VARIAVEL QUE SUPORTE MENOS ) E CASO O VALOR POSSA SER NAQUELA VARIÁVEL ENTÃO DEVE SER FEITO UMA CONVERSÃO

            // o nome das conversões é de acordo com tamanho de cada tipo
            // o tamanho do tipo 'int' é de 32bits então para converter para int é ToInt32
            // short tem 16bits = ToInt16
            // long tem 64bits = ToInt64
            long myLong2 = 10;
            int myInt2 = System.Convert.ToInt32(myLong2);
            short myShort2 = Convert.ToInt16(myInt2);


            Console.ReadKey();
        }
    }
}
