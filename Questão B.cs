using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= numero; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nA conta está finalizada!");
        Console.ReadKey();
    }
}
