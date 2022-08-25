using System;
using System.Globalization;

namespace Ex._09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um programa que leia quantos metros² existe num apartemento.
            Caso seja menor que 50m²: o programa deve retornar "apartamento compacto".
            Caso seja maior que 50m²: o programa deve retornar "apartamento super luxo".
            */
            Console.Write("Informe a largura do apartamento: ");
            float largura = float.Parse(Console.ReadLine());

            Console.Write("informe o comprimento do apartamento: ");
            float comprimento = float.Parse(Console.ReadLine());

            float area = largura * comprimento;

            Console.WriteLine($"Área total do apartamento: {area.ToString("F1", CultureInfo.InvariantCulture)}m²");

            if (area <= 50)
            {
                Console.WriteLine("Apartamento compacto.");
            }
            else
            {
                Console.WriteLine("Apartamento super luxo");
            }
        }
    }
}
