using System;

namespace Ex._07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que leia um número e exiba a tabuada dele. 
            */

            Console.Write("Informa um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("===================================");
            Console.WriteLine($"========= Tabuada do {n} ==========");
            Console.WriteLine("===================================");


            for (int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine($"{cont} x {n} = {n*cont}");
            }
        }
    }
}
