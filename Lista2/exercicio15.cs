using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class exercicio15
    {
        static void Main15(String[] args)
        {
            //Inicializando variáveis
            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, media = 0, rec = 0, mediarec = 0;

            //Entrada das notas
            Console.WriteLine("Entre com a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com a terceira nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Entre com a quarta nota: ");
            nota4 = Convert.ToInt32(Console.ReadLine());

            //Cálculo
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Condição
            if (media >= 7)

            {
                Console.WriteLine("Sua média foi: " + media + " Logo, você foi aprovado!");
            }

            if (media < 7)
            {
                Console.WriteLine("Entre com a nota de recuperação: ");
                rec = Convert.ToInt32(Console.ReadLine());

                mediarec = (media + rec);

                if (mediarec >= 7)
                {
                    Console.WriteLine("Sua média foi: " + mediarec + "\nLogo, você foi aprovado!");
                }
                else
                {
                    Console.WriteLine("Sua média foi: " + mediarec + " Logo, você foi reprovado!");
                }
            }

            Console.ReadKey();
        }
    }
}