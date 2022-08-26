using System;

namespace Ex._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Tipagem estática
            int a = 10;
            double b = 10.5 ;
            string c = "Nathan";
            float z = 5.10f;

            decimal taxa = 12.9m;
            DateTime dataHora = DateTime.Now;

            // Tipagem dinâmica
            var d = 5; // int
            var e = 5.5; // double
            var f = false; // bool
            var g = "Nathan"; // string
            var idadeStr = "21"; // string

            // Casting
            string taxa2 = taxa.ToString();
            int idadeInt = int.Parse(idadeStr);
            int idadeInt2 = Convert.ToInt32(idadeStr);
            */

            /*
            var nome = "Nathan";
            var sobrenome = "Santos";
            // var nomeCompleto = nome + sobrenome;
            var nomeCompleto = $"{nome} {sobrenome}";

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nomeCompleto.ToUpper()); // Tudo maiúsculo
            Console.WriteLine(nomeCompleto.ToLower()); // Tudo minúsculo
            Console.WriteLine(nomeCompleto.Substring(7)); // Exibe a partir do 7º caractere.
            Console.WriteLine(nomeCompleto.Substring(7, 5)); // Exibe a partir do 7º caractere, e exibe apenas 5 caracteres
            Console.WriteLine(nomeCompleto.Contains("o")); // Verifica se a letra (ou frase) contida no parâmetro, existe na string. Retorna valor booleano.
            Console.WriteLine(nomeCompleto.Contains("ht")); // Rertonará False.
            Console.WriteLine(nomeCompleto.StartsWith("N")); // Retorna True se a string começar com a string informada no parâmetro, senão retorna False.
            Console.WriteLine(nomeCompleto.EndsWith("s")); // Retorna True se a string terminar com a string informada no parâmetro, senão retorna False.
            Console.WriteLine(nomeCompleto.IndexOf("a")); // Retorna a posição da string informada no parâmetro.
            Console.WriteLine(nomeCompleto.LastIndexOf("a")); // Retorna a posição da string informada no parâmetro, começando pelo final da string analisada.
            */

            /*
            var hoje = DateTime.Now;
            var hoje2 = DateTime.Today;
            var data1 = new DateTime(2022, 09, 18);
            var data2 = new DateTime(2022, 09, 18, 09, 23, 35); // aaaa, mm, dd, hh, mm, ss
            var data3 = "20/08/2022 12:21:51";
            var data4 = DateTime.Parse(data3);

            Console.WriteLine(data3);
            Console.WriteLine(data4);
            Console.WriteLine($"Dia: {data4.Day}");
            Console.WriteLine($"Mês: {data4.Month}");
            Console.WriteLine($"Ano: {data4.Year}");
            Console.WriteLine($"Hora: {data4.Hour}");
            Console.WriteLine($"Minuto: {data4.Minute}");
            Console.WriteLine($"Segundo: {data4.Second}");

            Console.WriteLine(data4.AddDays(4));
            Console.WriteLine(data4.AddDays(-7));
            Console.WriteLine(data4.AddDays(30));
            */

            /*
            int[] numeros = new int[3]; // Declaração de uma array
            numeros[0] = 10;
            numeros[1] = 11;
            numeros[2] = 12;

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            */

            /*
            int[] pares = new int[3] { 2, 4, 6 };
            int[] impares = new int[3] {1, 3, 5};

            Console.WriteLine(pares[0]);
            Console.WriteLine(pares[1]);
            Console.WriteLine(pares[2]);

            Console.WriteLine(impares[0]);
            Console.WriteLine(impares[1]);
            Console.WriteLine(impares[2]);
            
            string[] nomes = new string[] {"João", "Pedro", "Fabio", "Genaro", "Claudete"};

            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            Console.WriteLine(nomes[3]);
            Console.WriteLine(nomes[4]);
            */

            /*
            var a = 5;
            var b = 5;
            var c = 5;
            var d = 5.0;
            var e = 5;

            a += 2; // a = a + 2;
            b -= 2; // b = b - 2;
            c *= 2; // c = c * 2;
            d /= 2; // d = d / 2;
            e %= 2; // e = e % 2;

            // b++; // b = b + 1 ;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            */

            /*
            var a = 2;
            var b = 3;

            Console.WriteLine(a == b); // Igual
            Console.WriteLine(a != b); // Diferente
            Console.WriteLine(a > b); // Maior
            Console.WriteLine(a < b); // Menor
            Console.WriteLine(a >= b); // Maior ou igual
            Console.WriteLine(a <= b); // Menor ou igual
            */

            var ativo = false;
            var a = 3;
            var b = 5;

            Console.WriteLine(ativo == true);
        }
    } 
}
