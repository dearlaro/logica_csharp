using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class exercicio17
    {
        static void Main17(string[] args)
        {
            //Inicializando a variável
            int num;

            //Entrada
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());

            //Condições
            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Válido");

            }
            else
            {
                Console.WriteLine("Invalido");
            }

            Console.ReadKey();
        }
    }
}