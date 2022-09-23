using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{

    class exercicio11
    {

        static void Main11(String[] args)
        {
            //Inicializando as variáveis
            int a = 0, b = 0, var = 0;

            //apresentação
            Console.WriteLine("Programa para efetuar a troca dos valores das variáveis!");

            //Entrada de valores
            Console.WriteLine("Entre com o valor da variável A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Entre com o valor da variável B: ");
            b = Convert.ToInt16(Console.ReadLine());

            var = a;
            a = b;
            b = var;

            //Apresentação
            Console.WriteLine("Os valores trocados ficaram: A = " + a + " e B = " + b);

            Console.ReadKey();

        }

    }
}

