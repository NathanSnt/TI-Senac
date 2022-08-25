using System;
using System.Globalization;

namespace Ex._06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que leia o valor total de uma compra, quanto o usuário pagou e quanto deverá receber de troco.
             */

            Console.WriteLine("=======================================");
            Console.WriteLine("=========       ATACADÃO      =========");
            Console.WriteLine("=======================================");

            Console.Write("Informe o valor total da sua compra: R$ ");
            float totCompra = float.Parse(Console.ReadLine());

            Console.Write("Informe o valor pago ao caixa: R$ ");
            float pago = float.Parse(Console.ReadLine());

            float troco = pago - totCompra;

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("=========       ATACADÃO      =========");
            Console.WriteLine("=======================================");

            if (troco < 0)
            {
                Console.WriteLine("Você não tem dinheiro suficiente para realizar esta compra!");
                Console.WriteLine($"Está faltando R${(totCompra - pago).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Valor da compra: R${(totCompra).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Valor pago: R${(pago).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Valor do troco: R${(troco).ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
