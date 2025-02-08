using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número 5 para motrar sua tabuada:");
        int numero = 5;

        // Faz a conversão para inteiro.
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, insira o número 5.");
        }

        Console.WriteLine("A tabuada do numero 5 é:");

        // Exibe a tabuada do número 5 até 10
        for (int i = 1; i <= 10; i++)
        {
            int resultado = 5 * i;
            Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            Console.ReadKey();
        }
    }
}
