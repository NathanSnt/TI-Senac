using System;

namespace Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }
    }
}
