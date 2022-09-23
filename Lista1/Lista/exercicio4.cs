using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e por último  C  com  D.  Note  que  para  cada  operação  serão  utilizadas  seis  combinações.  Assim  sendo,  devem  ser realizadas doze operações de processamento, sendo seis para as adições e seis para as multiplicações. 

namespace Lista
{
    class exercicio4
    {
		static void Main4(String[] args)
		{

			//Inicializando as variáveis
			int A, B, C, D;

			//Apresentação
			Console.WriteLine("Programa para calculo de adição e multiplicação com o conceito de propriedade distributiva.");

			//Entrada dos valores
			Console.WriteLine("Entre com o primeiro número: ");
			A = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Entre com o segundo número: ");
			B = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Entre com o terceiro número: ");
			C = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Entre com o quarto número: ");
			D = Convert.ToInt32(Console.ReadLine());

			//Apresentação dos resultados
			Console.WriteLine("A + B é: " + (A + B));
			Console.WriteLine("A x B é: " + (A * B));
			Console.WriteLine("A + C é: " + A + C);
			Console.WriteLine("A x C é: " + (A * C));
			Console.WriteLine("A + D é: " + (A + D));
			Console.WriteLine("A x D é: " + (A * D));
			Console.WriteLine("B + C é: " + (B + C));
			Console.WriteLine("B x C é: " + (B * C));
			Console.WriteLine("B + D é: " + (B + D));
			Console.WriteLine("B * D é: " + (B * D));
			Console.WriteLine("C + D é: " + (C + D));
			Console.WriteLine("C x D é: " + (C * D));


			Console.ReadKey();
		}
	}
}
