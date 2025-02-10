using System;

class Program
{
    static void Main()
    {
        // Criação do vetor de inteiros
        int[] numeros = { 5, 2, 8, 1, 4 };

        // Vetor original
        Console.WriteLine("Vetor original:");
        ExibirVetor(numeros);

        // Ordenando em ordem crescente
        Array.Sort(numeros);

        // Invertendo em ordem decrescente
        Array.Reverse(numeros);

        // Exibindo o vetor ordenado em ordem decrescente
        Console.WriteLine("Vetor ordenado em ordem decrescente:");
        ExibirVetor(numeros);
    }

    static void ExibirVetor(int[] vetor)
    {
        foreach (int numero in vetor)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
