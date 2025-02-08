using System;

class Program
{
    static void Main()
    {
        int soma = 0; // Variável para armazenar os números pares

        for (int i = 2; i <= 100; i += 2) // começa em 2 e incrementa os números de 2 em 2
        {
            soma += i; // Soma os números pares
        }

        Console.WriteLine("A soma de todos os números pares até 100 é: " + soma);
        Console.ReadKey();
    }
}
