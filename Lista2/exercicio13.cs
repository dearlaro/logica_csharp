using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio13
    {
        static void Main13(String[] args)
        {

            //Inicializando variáveis
            int num1 = 0, num2 = 0, num3 = 0;
            Console.WriteLine("Programa para apresentar os valores em ordem decrescente");

            //Entrada dos valores 
            Console.WriteLine("Entre com o valor do primeiro número: ");
            num1 = Console.Read();
            Console.WriteLine("Entre com o valor do segundo número: ");
            num2 = Console.Read();
            Console.WriteLine("Entre com o valor do terceiro número: ");
            num3 = Console.Read();

            //Condição
            if (num1 >= num2 && num2 >= num3)
            {
                Console.WriteLine("Ordem descrescente é: " + num1 + num2 + num3);
            }
            if (num1 <= num2 && num2 <= num3)
            {
                Console.WriteLine("Ordem descrescente é: " + num3 + num2 + num1);
            }
            if (num2 <= num1 && num1 <= num3)
            {
                Console.WriteLine("Ordem descrescente é: " + num3 + num1 + num2);
            }
            if (num1 <= num3 && num3 <= num2)
            {
                Console.WriteLine("Ordem descrescente é: " + num2 + num3 + num1);
            }
            if (num2 <= num3 && num3 <= num1)
            {
                Console.WriteLine("Ordem descrescente é: " + num1 + num3 + num2);
            }
            if (num3 <= num1 && num1 <= num2)
            {
                Console.WriteLine("Ordem descrescente é: " + num2 + num1 + num3);
            }


            Console.ReadKey();
        }
    }
}
