using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{

	class exercicio19
	{
		public static void Main19(String[] args)
		{

			//Inicializando as variaveis 
			int A, B, C;

			//Apresentação
			Console.WriteLine("Programa para verificar de Triângulo\n\n");

			//Entrada dos valores
			Console.WriteLine("Digite o lado A=");
			A = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o lado B=");
			B = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o lado C=");
			C = Convert.ToInt32(Console.ReadLine());

			//Condições
			if (A < B + C && B < A + C && C < A + B)
			{
				if (A == B && B == C)
				{
					Console.WriteLine("O triângulo é Eqüilátero.");
				}
				else if (A == B || A == C || B == C)
				{
					Console.WriteLine("O triângulo é Isósceles.");
				}
				else
				{
					Console.WriteLine("O triângulo é Escaleno.");
				}
			}
			else
			{
				Console.WriteLine("Os lados fornecidos não caracterizam um triângulo");

			}

			Console.ReadKey();

		}

	}
}