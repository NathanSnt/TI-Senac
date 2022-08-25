using System;
using System.Globalization;

namespace Ex._08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que calcule a área de um terreno retângular e leia o preços por metro² e informe o valor do terreno
             */
            Console.WriteLine("*** CALCULADORA DE VALOR DE TERRENO RETANGULAR ***");
            Console.Write("Informe o comprimento do terreno: ");
            float comprimento = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.Write("Informe a largura do terreno: ");
            float largura = float.Parse(Console.ReadLine());
            Console.Beep();

            if (comprimento != largura) // Caso o terreno seja retangular.
            {
                float area = comprimento * largura;

                Console.Write("Informe o valor do m²: ");
                float valorM2 = float.Parse(Console.ReadLine());

                float valorTerreno = valorM2 * area;

                Console.Clear();
                Console.Beep();

                Console.WriteLine("\n---- RESULTADO ----\n");

                Console.WriteLine($"Área do terreno : {area.ToString("F1", CultureInfo.InvariantCulture)}m²");
                Console.WriteLine($"Valor do terreno: R${valorTerreno.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else // Caso o terreno seja quadrado.
            {
                Console.Clear();
                Console.WriteLine("O terreno tem que ser retangular!");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }
    }
}
