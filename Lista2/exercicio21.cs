using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{

    class exercicio21
    {
        public static void Main21(String[] args)
        {
            Console.WriteLine("Programa que informa se o número é positivo ou negativo");

            //Inicalizando as variaveis
            int num = 0;
            string cont;
            do
            {
                //Entrada dos números
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                //Condição
                if (num >= 0)
                {
                    Console.WriteLine("O número é positivo!");
                }
                else
                {
                    Console.WriteLine("O número é negativo!");
                }

                Console.WriteLine("Deseja continuar? S / N");
                cont = Console.ReadLine();

            } while (cont == "S" || cont == "s");
            Console.ReadKey();
        }
    }
}