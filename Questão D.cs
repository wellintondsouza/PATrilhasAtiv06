using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero;
        int soma = 0;
       
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {

		Console.WriteLine("A soma entre os números é:");

        }
        for (int i = 1; i <= numero; i ++)
        {
        	soma += i;
        }
        Console.WriteLine("A soma entre os números é:" +soma);
        	Console.ReadKey();
        }
}
