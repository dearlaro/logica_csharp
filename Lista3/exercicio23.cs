using System;

namespace Lista3
{
    class exercicio23
    {
        static void Main23(string[] args)
        {
            //Inicializando as variáveis
            int num1 = 0, num2 = 0, operacao;
            string op;

            Console.WriteLine("Programa para realizar operações matemáticas!");
            //Entrando com os valores
            Console.WriteLine("Entre com o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Escolha a operação
            Console.WriteLine("Escolha uma operação a ser realizada: \n1 – Adição \n2 – Subtração \n3 – Multiplicação \n4 – Divisão ");
            op = Console.ReadLine();
            
            //Switch case
            switch (op)
            {
                case "1":
                    operacao = num1 + num2;
                    Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + operacao);
                    break;
                case "2":
                    operacao = num1 - num2;
                    Console.WriteLine("A subtração de " + num1 + " e " + num2 + " é igual a " + operacao);
                    break;
                case "3":
                    operacao = num1 * num2;
                    Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " é igual a " + operacao);
                    break;
                case "4":
                    operacao = num1 / num2;
                    Console.WriteLine("A divisão de " + num1 + " e " + num2 + " é igual a " + operacao);
                    break;
                default:
                    Console.WriteLine("Não foi possível realizar a operação");
                    break;
            }
            Console.ReadKey();
        }
    }
}
