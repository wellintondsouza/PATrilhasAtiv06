using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            string nome = Console.ReadLine();
            nomes.Add(nome); // Adiciona o nome à lista
        }

        // Exibindo a listagem de nomes
        Console.WriteLine("\nListagem de Nomes:");
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nomes[i]}");
            Console.ReadKey();
        }
    }
}
