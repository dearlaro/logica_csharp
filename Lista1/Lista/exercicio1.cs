using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.  

namespace Lista
{
    class exercicio1
    {
        static void Main1(string[] args)
        {
            int quantMax = 0;
            int quantMin = 0;
            int quantMed = 0;

            //Apresentação
            Console.WriteLine("Programa para calcular o estoque médio da peça!");


            //Quantidade mínima
            Console.WriteLine("Insira a quantidade mínima da peça no estoque: ");
            quantMin = Convert.ToInt32(Console.ReadLine());

            //Quantidade máxima
            Console.WriteLine("Insira a quantidade máxima da peça no estoque: ");
            quantMax = Convert.ToInt32(Console.ReadLine());
            
            //Cálculo de média
            quantMed = (quantMax + quantMin) / 2;

            Console.WriteLine("O estoque médio é: " + quantMed);
            Console.ReadKey();
        }
    }
}

