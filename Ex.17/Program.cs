using System;

namespace Ex._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a opção desejada: ");

            var opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    Console.WriteLine("Opção 01 - Seu saldo é de R$ 100,00");
                    break;
                case "2":
                    Console.WriteLine("Opção 02 - Informe o valor do depósito: ");
                    break;
                case "3":
                    Console.WriteLine("Opção 03 - Informe o valor a ser sacado: ");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
