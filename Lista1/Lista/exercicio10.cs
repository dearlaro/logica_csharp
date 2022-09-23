using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 

namespace Lista
{
    class exercicio10
    {
        static void Main10(string[] args)
        {
            bool Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false, MenorOuIgual = false;
            int num1 = 0, num2 = 0;

            Console.WriteLine("Programa para apresentar os relacionamentos entre dois números!\n");

            Console.WriteLine("Entre com o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Igual = true;
            }
            if (num1 != num2)
            {
                NaoIgual = true;
            }
            if (num1 > num2)
            {
                Maior = true;
            }
            if (num1 < num2)
            {
                Menor = true;
            }
            if (num1 >= num2)
            {
                MaiorOuIgual = true;
            }
            if (num1 <= num2)
            {
                MenorOuIgual = true;
            }

            Console.WriteLine("\n\nVamos ver se os relacionamentos são verdadeiros ou falsos. \n\n");
            Console.WriteLine("O primeiro número é igual ao segundo? \n" + Igual);
            Console.WriteLine("O primeiro número é diferente do segundo? \n" + NaoIgual);
            Console.WriteLine("O primeiro número é maior que o segundo? \n" + Maior);
            Console.WriteLine("O primeiro número é menor que o segundo? \n" + Menor);
            Console.WriteLine("O primeiro número é maior ou igual ao segundo? \n" + MaiorOuIgual);
            Console.WriteLine("O primeiro número é menor ou igual ao segundo? \n" + MenorOuIgual);

            Console.ReadKey();
        }
    }
}
