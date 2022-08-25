using System;

namespace Ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um programa para calcular a média dos alunos

            string nome;
            double nota1, nota2, media;

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média do aluno " + nome + " é : " + media);

            if (nome == "Jão")
            {
                if (media < 7)
                {
                    Console.WriteLine("Aluno reprovado, mas aprova ele por piedade.");
                }
            } else if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado!");
            } else
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}