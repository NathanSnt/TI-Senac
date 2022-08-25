using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t###########################\n\t Lojinha Virtual Aleatória\n\t###########################\n\n");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu saldo atual : ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do produto que deseja comprar: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Informe o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            if (saldo >= valorProduto)
            {
                Console.WriteLine("\n\n************ CONFIRMAÇÃO DE COMPRA ************");
                Console.WriteLine($"Produto: {nomeProduto}");
                Console.WriteLine($"Valor: R${valorProduto}");
                Console.WriteLine($"\nSaldo atual: R${saldo}");
                Console.WriteLine($"Saldo após a compra: R$ {saldo - valorProduto}");
                Console.WriteLine("\nTecle Y para confirma ou N para negar.");

                char confirmar = char.Parse(Console.ReadLine());
                if (confirmar == 'Y' || confirmar == 'y')
                {
                    saldo -= valorProduto;
                    Console.WriteLine("\nCompra realizado com sucesso!!");
                    Console.WriteLine($"Saldo atual: {saldo}");
                }
                else
                {
                    Console.WriteLine("\nCancelando compra...");
                }
            }
            else
            {
                Console.WriteLine("\n\nSaldo insuficiente!");
                Console.WriteLine($"Você precisa de mais R${valorProduto - saldo} para conseguir concluir esta compra.");
                Console.WriteLine("Cancelando compra...");
            }
        }
    }
}