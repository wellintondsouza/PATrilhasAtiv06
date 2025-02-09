using System;

    class Program
    {
        static void Main()
        {
            double[] notas = { 10, 20, 30, 40, 50, 60 };
            double soma = 0;

            // Corrigindo a soma das notas
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i]; // Soma corretamente os valores do array
            }

            double media = soma / notas.Length; // Calcula a média

            Console.WriteLine($"A média das notas é: {media}"); // Mostra a média corretamente
        }
    }
