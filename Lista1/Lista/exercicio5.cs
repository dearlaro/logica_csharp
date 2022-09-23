using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor  da  distância,  basta  calcular  a  quantidade  de  litros  de  combustível  utilizada  na  viagem  com  a  fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais

namespace Lista
{
    class exercicio5
    {
        static void Main5(String[] args)
        {
            float tempGast = 0, velMed = 0, distPerc = 0, qtdL = 0;

            Console.WriteLine("Programa para calcular a quantidade de litros usado em uma viagem!");
            Console.WriteLine("Entre com o tempo gasto na viagem: ");
            tempGast = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Entre com a velocidade média: ");
            velMed = Convert.ToSingle(Console.ReadLine());

            distPerc = tempGast * velMed;

            qtdL = distPerc / 12;

            Console.WriteLine("A velocidade média foi: " + velMed);
            Console.WriteLine("O tempo gasto na viagem foi: " + tempGast);
            Console.WriteLine("A distância percorrida foi: " + distPerc + "KM");
            Console.WriteLine("A quantidade de litros necessários foi: " + qtdL + "L");

            Console.ReadKey();

        }
    }
}
