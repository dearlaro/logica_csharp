using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    class exercicio25
    {
        static void Main(string[] args)
        {
            //Inicializando as variáveis
            double peso, alt;
            string genero;

            //Entrada dos valores
            Console.WriteLine("Programa para calcaular o peso ideal!");
            Console.WriteLine("Entre com a sua altura: ");
            alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu gênero: \nF- feminino \nM- masculino");
            genero = Console.ReadLine().ToUpper();

            //Switch
            switch (genero)

            {
                case "M":
                    peso = (72.2 * alt) - 58;
                    Console.WriteLine("Seu peso ideal é " + peso);

                    break;

                case "F":
                    peso = (62.1 * alt) - 47.7;
                    Console.WriteLine("Seu peso ideal é " + peso);
                    break;
            }
        Console.ReadKey();
        }
    }
}
