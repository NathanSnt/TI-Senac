using System;

namespace Ex._19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;

            while (i <= 5000) // Contagem de 0 à 5000
            {
                Console.WriteLine(i);
                i++;
            }

            do // Contagem de 5000 à 0
            {
                Console.WriteLine(i);
                i--;
            } 
            while (i >= 0);
            */

            /*
            var indice = 0;
            var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };

            // Console.WriteLine(versoes[0]);
            // Console.WriteLine(versoes[1]);
            // Console.WriteLine(versoes[2]);
            // Console.WriteLine(versoes[3]);

            while (indice < versoes.Length)
            {
                Console.WriteLine(versoes[indice]);
                Console.WriteLine(indice);
                indice++;
            */

            /*
            var indice = 0;
            var carros = new[] { "Celta", "Gol", "Corsa", "Renegade", "Fusca", "Palio", "UP"};

            while (indice < carros.Length)
            {
                Console.WriteLine(carros[indice]);
                indice++;
            }
            */

            /*
            var contador = 10;
            var opc = "";

            do
            {
                Console.WriteLine("Digite a opção: ");
                Console.WriteLine("1 - SAQUE | 2 - DEPÓSITO | 3 - SALDO | 0 - SAIR");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Saque selecionado.");
                        break;
                    case "2":
                        Console.WriteLine("Depósito selecionado.");
                        break;
                    case "3":
                        Console.WriteLine("Saldo disponível: R$ 100,00");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            while (opc != "0");
            */

            
            var carros = new[] { "Celta", "Gol", "Corsa", "Renegade", "Fusca", "Palio", "UP" };

            /*
            for (int indice = 0; indice < carros.Length; indice++)
            {
                Console.WriteLine(carros[indice]);
            }
            */

            foreach (var carro in carros)
            {
                Console.WriteLine(carro);
            }
        }
    }
}
