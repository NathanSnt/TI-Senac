using System;

namespace Ex._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que leia o horário atual e caso o horário esteja entre:
            01:00 - 05:59 ** Retorna Boa madrugada!
            06:00 - 11:59 ** Retorna Bom dia!
            12:00 - 17:59 ** Retorna Boa tarde!
            18:00 - 00:59 ** Retorna Boa noite!
            */

            Console.Write("Informe um horário (HH:MM): ");
            // string hora = Console.ReadLine();
            // DateTime horario = DateTime.Parse(hora);
            DateTime horario = DateTime.Parse(Console.ReadLine());

            if (horario >= DateTime.Parse("01:00") && horario < DateTime.Parse("06:00"))
            {
                Console.WriteLine("Boa madrugada!");
            }
            else if (horario >= DateTime.Parse("06:00") && horario < DateTime.Parse("12:00"))
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horario >= DateTime.Parse("12:00") && horario < DateTime.Parse("18:00"))
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

        }
    }
}
