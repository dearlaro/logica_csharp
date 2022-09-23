using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio16
    {
        static void Main16(String[] args)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("Entre com o primeiro número: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O maior número é: " + num1 + "\nE o menor número é: " + num2);
            }
            if (num2 > num1)
            {
                Console.WriteLine("O maior número é: " + num2 + "\nE o menor número é: " + num1);
            }
            if (num1 == num2)
            {
                Console.WriteLine("Os números digitados são iguais!");
            }
            Console.ReadKey();

        }
    }
}
