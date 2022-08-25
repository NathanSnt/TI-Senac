using System;

namespace Ex._10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Criar um programa que leia um número e retorne se é positivo ou negativo
            */
            Console.Write("Informe um número: ");
            float num = float.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"O número {num} é negativo!");
            }
            else
            {
                Console.WriteLine($"O número {num} é positivo!");
            }
        }
    }
}
