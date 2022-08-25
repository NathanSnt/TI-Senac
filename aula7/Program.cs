using System;

namespace aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[6] {"Nathan", "Carlos", "nome3", "nome4", "nome5", "nome6"};
            for (int contador = 0; contador < nomes.Length; contador++)
            {
                Console.WriteLine($"{contador}. {nomes[contador]}");
            }
        }
    }
}
