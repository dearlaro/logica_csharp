using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius. 
namespace Lista
{
    class exercicio7
    {
        static void Main7(String[] args)
        {
            //Inicializando as variáveis
            int C = 0, F = 0;
            
            //Apresentação
            Console.WriteLine("Programa para converter a temperatura de Fahrenheit para Celsius!");

            //Entrada dos celsius
            Console.WriteLine("Entre com um valor em graus Fahrenheit: ");
            F = Convert.ToInt16(Console.ReadLine());

            //Cálculo
            C = (F - 32) * 5 / 9;

            //Resultado
            Console.WriteLine("A temperatura " + F + "°F é igual a " + C + "°C!!");

            Console.ReadKey();

        }
    }
}
