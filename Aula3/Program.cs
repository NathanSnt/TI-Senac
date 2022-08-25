using System;
class Aula3
{
    static void Main()
    {
        char primeiraLetraNome;
        string nome;
        int idade;
        float valor;
        double valorAlto;
        bool nomeComecaComN;

        primeiraLetraNome = 'N';
        nome = "Nathan";
        idade = 21;
        valor = 0.4f;
        valorAlto = 1234.45;
        nomeComecaComN = true;

        Console.WriteLine("Primeira letra do nome: " + primeiraLetraNome);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Valor: " + valor);
        Console.WriteLine("Valor alto: " + valorAlto);
        Console.WriteLine("Nome começa com N: " + nomeComecaComN);
    }
}