using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 15;
            int n3 = 20;
            int resultado;
            bool verdadeiro = true;
            bool falso = false;
            bool r;
            // Operadores aritméticos
            // + somar
            resultado = n1 + n2 + n3;
            Console.WriteLine($"{n1} + {n2} + {n3} = {resultado}");

            // - subtrair
            resultado = n1 - n2 - n3;
            Console.WriteLine($"{n1} - {n2} - {n3} = {resultado}");

            // * multiplicação
            resultado = n1 * n2 * n3;
            Console.WriteLine($"{n1} * {n2} * {n3} = {resultado}");

            // / divisão
            resultado = n1 / n2 / n3;
            Console.WriteLine($"{n1} / {n2} / {n3} = {resultado}");

            // // resto da divisão
            resultado = n1 % n2 % n3;
            Console.WriteLine($"{n1} % {n2} % {n3} = {resultado}");

            // Operadores de comparação
            // > maior que
            bool n1Maiorn2 = n1 > n2;
            Console.WriteLine($"{n1} maior que {n2}: {n1Maiorn2}");

            // < menor que
            bool n1Menorn2 = n1 < n2;
            Console.WriteLine($"{n1} menor que {n2}: {n1Menorn2}");

            // > maior ou igual que
            bool n1MaiorIgualn2 = n1 >= n2;
            Console.WriteLine($"{n1} maior ou igual que {n2}: {n1MaiorIgualn2}");

            // < menor ou igual que
            bool n1MenorIgualn2 = n1 <= n2;
            Console.WriteLine($"{n1} menor ou igual que {n2}: {n1MenorIgualn2}");

            // == igual
            bool igual = n1 == n2;
            Console.WriteLine($"{n1} == {n2} = {igual}");

            // != diferente
            bool diferente = n1 != n2;
            Console.WriteLine($"{n1} != {n2} = {diferente}");

            // Operadores boleanos
            // && E
            r = verdadeiro && falso;
            Console.WriteLine($"{verdadeiro} && {falso} = {r}");

            // || OU
            r = verdadeiro || falso;
            Console.WriteLine($"{verdadeiro} || {falso} = {r}");

            // ! NOT
            r = !verdadeiro;
            Console.WriteLine($"!{verdadeiro} = {r}");
        }
    }
}
