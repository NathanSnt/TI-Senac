using System;

namespace Ex._11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa que leia duas notas e apresenta a média final.
             * Se média for maior ou igual à 6: Aluno aprovado
             * Senão: Aluno reprovado
            */
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());

            float media = (n1 + n2) / 2;

            if (media >= 6)
            {
                Console.WriteLine($"Com a média final de {media}, o aluno {nome} foi aprovado!");
            }
            else
            {
                Console.WriteLine($"Com a média final de {media} o aluno {nome} foi reprovado!");
            }
        }
    }
}
