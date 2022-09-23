using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio18
    {
        static void Main18(String[] args)
        {
            String val;
            int CODIGO;

            Console.WriteLine("Escreva um numero entre ('1, 2, 3')");
            val = Console.ReadLine();

            CODIGO = int.Parse(val);

            switch (CODIGO)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;

                case 3:
                    Console.WriteLine("Três");
                    break;

                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

        }
    }
}
