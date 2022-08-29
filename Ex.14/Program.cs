using System;

namespace Ex._14
{
    class Program
    {
        static void Main(string[] args)
        {
            var idade = 16;
            var nota = 6;

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
                Console.WriteLine("Cadastro autorizado.");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Menor de idade");
                Console.WriteLine("Autorização dos responsáveis necessária.");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
