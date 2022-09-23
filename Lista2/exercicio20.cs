using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio20
    {
        public static void Main20(String[] args)
        {
            int a, b, c, mult, div;

            Console.WriteLine("Entre com o primeiro valor (maior que 0): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Valor menor que zero, insira novamente: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entre com o primeiro valor (maior que 0): ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Valor menor que zero, insira novamente: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entre com o primeiro valor (maior que 0): ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("Valor menor que zero, insira novamente: ");
                c = Convert.ToInt32(Console.ReadLine());
            }

            //Cálculos
            //abc
            if (a >= b && b >= c)
            {
                mult = c * a;
                div = a / c;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
            //cba
            if (a <= b && b <= c)
            {
                mult = a * c;
                div = c / a;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
            //cab
            if (b <= a && a <= c)
            {
                mult = b * c;
                div = c / b;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
            //bca
            if (a <= c && c <= b)
            {
                mult = a * b;
                div = b / a;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
            //acb
            if (b <= c && c <= a)
            {
                mult = b * a;
                div = a / b;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
            //bac
            if (c <= a && a <= b)
            {
                mult = c * b;
                div = b / c;
                Console.WriteLine("A multiplicação é: " + mult);
                Console.WriteLine("A divisão é: " + div);
            }
        }
    }
}
