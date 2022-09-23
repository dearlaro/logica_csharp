using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{

    class exercicio22
    {
        public static void Main22(String[] args)
        {

            Console.WriteLine("Programa que lê números positivos e negativos");

            //Inicalizando as variaveis
            int num = 0;
            int A = 0;
            int B = 0;

            //Entrada do valor
            Console.WriteLine("Informe um número");
            num = Convert.ToInt32(Console.ReadLine());

            //Condições
            if (num >= 0)
            {
                A = num;
                Console.WriteLine("O número digitado é positivo, ou seja, o resultado da variável A é: " + A);
            }
            else
            {
                B = num;
                Console.WriteLine("O número digitado é negativo, ou seja, o resultado da variável B é: " + B);
            }

            Console.ReadKey();

        }
    }
}