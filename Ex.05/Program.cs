using System;
using System.Globalization;

namespace Ex._05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para calcular o aumento de salário
             de um funcionário X. Exibindo:

             - % de aumento do salário
             - Aumento de Reais
             - Salário final
             */

            double salarioAtual, salarioFinal, porcentagem;

            Console.WriteLine("===================================================");
            Console.WriteLine("======    PROGRAMA DE AUMENTO DE SALÁRIO     ======");
            Console.WriteLine("===================================================");

            Console.Write("Digite o nome do(a) funcionário(a): ");
            string nome = Console.ReadLine();

            Console.Write($"Digite o salário atual de {nome}: ");
            salarioAtual = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de aumento do salário: ");
            porcentagem = double.Parse(Console.ReadLine());

            salarioFinal = salarioAtual * (1 + (porcentagem / 100));
            //salarioFinal = Math.Round(salarioFinal, 2);

            Console.Clear();

            Console.WriteLine("===================================================");
            Console.WriteLine("======         RESULTADO DA OPERAÇÃO         ======");
            Console.WriteLine("===================================================");

            //Console.WriteLine($"Salário antigo de {nome}: R${salarioAtual}");
            //Console.WriteLine($"Salário atual de {nome} : R${salarioFinal}");
            Console.WriteLine($"Salário antigo de {nome}: R${salarioAtual.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Salário atual de {nome} : R${salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de diferença ({porcentagem}%): R${(salarioAtual * (porcentagem / 100)).ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Valor de diferença ({porcentagem}%): R${Math.Round(salarioAtual * (porcentagem / 100), 2)}");

        }
    }
}
