/*
Programa para ler notas de 3 provas, calcular e exibir a média e o nome do aluno.
*/

using System;

namespace Ex._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("O aluno " + nome + ", obteve " + media + " pontos na média.");
        }
    }
}
