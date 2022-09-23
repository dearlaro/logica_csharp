using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    class exercicio24
    {
        static void Main24(string[] args)
        {
            //Inicializando as variáveis
            int num1 = 0, num2 = 0, op;

            Console.WriteLine("Programa para realizar verificações! ");
            //Entrando com os valores
            Console.WriteLine("Entre com o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Escolha a operação
            Console.WriteLine("Escolha uma opção a ser verificada: \n1 – Verificar se um dos números lidos é ou não múltiplo do outro \n2 – Verificar se os dois números lidos são pares \n3 – Verificar se a média dos dois números é maior ou igual a 7. \n4 – Sair  ");
            op = Convert.ToInt32(Console.ReadLine());

            //Switch
            switch (op)
            {
                //Múltiplos ou não
                case 1:
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Sim, um dos números é múltiplo do outro");
                    }
                    else
                    {
                        Console.WriteLine("Não, nenhum dos números é múltiplos do outro");
                    }
                    break;
               //Pares ou ímpares
                case 2:
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Sim, os dois números lidos são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Não, os dois números lidos são ímpares.");
                    }
                    break;
                //Média igual a 7
                case 3:
                    if ((num1 + num2) / 2 >= 7)
                    {
                        Console.WriteLine("Sim, a média dos dois números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7.");
                    }
                    break;
                 //Sair
                case 4:
                    break;
            }
        }
    }
}
