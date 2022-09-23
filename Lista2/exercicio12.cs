using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio12
    {
        static void Main12(String[] args)
        {

            //Inicializando as variáveis
            int num = 0, soma = 0;

            //Apresentação
            Console.WriteLine("Programa para apresentar o módulo de um número");

            //Entrada das variáveis
            Console.WriteLine("Entre com o número: ");
            num = Convert.ToInt16(Console.ReadLine());

            //Condição
            if (num >= 0)
            {
                soma = num * (-1);
            }
            else
            {
                soma = num * (-1);
            }

            //Apresentação
            Console.WriteLine("O módulo do valor digitado é: " + soma);
            Console.ReadKey();
        }
    }
}
