using System;

namespace Ex._18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que ao ser digitado:
            1 Retorne: Domingo
            2 Retorne: Segunda-feira
            3 Retorne: Terça-feira
            4 Retorne: Quarta-feira
            5 Retorne: Quinta-feira
            6 Retorne: Sexta-feira
            7 Retorne: Sábada
            */

            Console.Write("Digite um número entre 1 e 7: ");
            var dia = Console.ReadLine();

            switch (dia)
            {
                case "1":
                    Console.WriteLine("Domingo");
                    break;
                case "2":
                    Console.WriteLine("Segunda-feira");
                    break;
                case "3":
                    Console.WriteLine("Terça-feira");
                    break;
                case "4":
                    Console.WriteLine("Quarta-feira");
                    break;
                case "5":
                    Console.WriteLine("Quinta-feira");
                    break;
                case "6":
                    Console.WriteLine("Sexta-feira");
                    break;
                case "7":
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("O número tem que estar entre 1 e 7.");
                    break;
            }
        }
    }
}
