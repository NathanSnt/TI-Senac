using System;

namespace Ex._15
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 1;
            while (nota != 0)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("Aprovado!");
                }
                else if (nota >= 5)
                {
                    Console.WriteLine("Recuperação!");
                }
                else
                {
                    Console.WriteLine("Reprovado!");
                }
            }
        }
    }
}
