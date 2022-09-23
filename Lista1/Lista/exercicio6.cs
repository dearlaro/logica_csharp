using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius. 

namespace Lista
{
    class exercicio6
    {
        static void Main6(String[] args)
        {
            //Inicializando as variáveis
            int C = 0, F = 0;

            //Apresentação
            Console.WriteLine("Programa para converter a temperatura em Celsius para Fahrenheit!");

            //Entrada dos celsius
            Console.WriteLine("Entre com um valor em graus Celsius: ");
            C = Convert.ToInt16(Console.ReadLine());

            //Cálculo
            F = (9 * C + 160) / 5;

            //Resultado
            Console.WriteLine("A temperatura " + C + "°C é igual a " + F + "°F!!");

            Console.ReadKey();

        }
    }
}
