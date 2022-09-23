using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados:
//-Identificação do vendedor
//-Código da peça -Preço unitário da peça
//-Quantidade vendida 

namespace Lista
{
	class exercicio3
	{
		static void Main3(String[] args)
		{
			//Inicializando as variáveis
			double idvendedor, peca, preco, qtdvenda, comissao;

			//Entrada dos valores
			Console.WriteLine("Entre com a identificação do vendedor: ");
			idvendedor = Double.Parse(Console.ReadLine());

			Console.WriteLine("Entre com o código da peça: ");
			peca = Double.Parse(Console.ReadLine());

			Console.WriteLine("Entre com o preço unitário da peça: ");
			preco = Double.Parse(Console.ReadLine());

			Console.WriteLine("Entre com a quantidade vendida: ");
			qtdvenda = Double.Parse(Console.ReadLine());

			//Cálculo de comissão
			comissao = ((qtdvenda * preco) * 0.05);

			//Resultados
			Console.WriteLine("Código do vendedor: " + idvendedor);
			Console.WriteLine("Código da peça: " + peca);
			Console.WriteLine("Comissão do vendedor: R$" + comissao);


			Console.ReadKey();
		}
	}
}
