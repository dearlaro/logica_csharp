using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio14
    {
        static void Main14(String[] args)
        {
            //Inicializando variáveis
            int num1 = 0, num2 = 0, sub = 0;

            //Entrada das variáveis
            Console.WriteLine("Entre com o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Condição
            if (num1 > num2)
            {
               sub = num1 - num2;
            }
            else
            {
               sub = num2 - num1;

            }

            //Apresentação
            Console.WriteLine("A diferença entre os números é: " + sub);

            Console.ReadKey();
        }
    }
}
