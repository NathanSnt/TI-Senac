using System;

namespace Aula5
{
    class Programa
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("********* Programa de pagamentos *********"); 
            Console.Write("Digite o seu nome: "); 
            string nome = Console.ReadLine(); 

            Console.Write("Digite a sua idade: "); 
            int idade = int.Parse(Console.ReadLine()); 

            Console.WriteLine("\nResultados:"); 
            Console.WriteLine("Seu nome: " + nome); 
            Console.WriteLine("Sua idade: " + idade
            */
            string primeiroNome, ultimoNome, nomeCompleto;

            primeiroNome = "Nathan";
            ultimoNome = "Santos";

            // Formas de concatenação (Todos dão o mesmo resultado.) 
            nomeCompleto = primeiroNome + " da Silva " + ultimoNome;
            Console.WriteLine(nomeCompleto);

            nomeCompleto = string.Concat(primeiroNome, " da Silva ", ultimoNome);
            Console.WriteLine(nomeCompleto);

            nomeCompleto = $"{primeiroNome} da Silva {ultimoNome}";
            Console.WriteLine(nomeCompleto);
        }
    }
}