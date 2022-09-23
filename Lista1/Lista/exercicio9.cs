using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 

namespace Lista
{
    class exercicio9
    {
        static void Main9(string[] args)
        {
            //Inicializando as variáveis
            int idade = 0;
            int meses = 0;
            int dias = 0;
            int conta = 0;

            //Apresentação
            Console.WriteLine("Programa para apresentar sua idade em dias!");
            
            //Entrada dos anos
            Console.WriteLine("Entre com seus anos de vida: ");
            idade = Convert.ToInt32(Console.ReadLine());

            //Entrada dos meses
            Console.WriteLine("Entre com os meses: ");
            meses = Convert.ToInt32(Console.ReadLine());

            //Entrada dos dias
            Console.WriteLine("Entre com os dias: ");
            dias = Convert.ToInt32(Console.ReadLine());

            //Conta
            conta = (idade * 365) + (meses * 30) + dias ;

            Console.WriteLine("Seus dias de vida são: " + conta);

            Console.ReadKey();
        }
    }
}
