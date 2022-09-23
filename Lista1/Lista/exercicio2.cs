using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa que:
//-Leia a cotação do dólar
//-Leia um valor em dólares
//-Converta esse valor para Real
//-Mostre o resultado 

namespace Lista1
{

	class exercicio2
	{

		static void Main2(String[] args)
		{

			//Inicializando as variáveis
			double cotdolar, valor, real;


			//Entrada dos números

			Console.WriteLine("Programa para calcular o valor de dolar para reais! \n\n ");

			Console.WriteLine("Entre com a cotação do dólar: ");
			cotdolar = Double.Parse(Console.ReadLine());

			Console.WriteLine("Entre com o valor em dolar: ");
			valor = Double.Parse(Console.ReadLine());

			//Conta

			real = cotdolar * valor;

			Console.WriteLine("O valor em reais é: " + real + " \n ");

			Console.ReadKey();

		}

	}
}
