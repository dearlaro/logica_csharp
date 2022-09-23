using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: V =  3.14159 * R * R * A Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura. 

namespace Lista
{

    class exercicio8
    {
        static void Main8(string[] args)
        {
            //Inicializando as variáveis
            double volume = 0;
            double raio = 0;
            double altura = 0;

            Console.WriteLine("Programa para calcular o volume de uma lata de óleo!");
            //Solicitando a entrada dos valores
            Console.WriteLine("Entre com o valor do raio da lata de óleo: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com a altura da lata de óleo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Cálculo realizado
            volume = (3.14169 * raio * raio * altura);
            Console.WriteLine("O volume da lata de óleo é: " + volume + "cm³");

            Console.ReadKey();
        }
       
    }
}
