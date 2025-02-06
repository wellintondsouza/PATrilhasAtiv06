using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número 0");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
           Console.WriteLine("Números pares entre 0 e 100 é :" + numero + ":");

        
        for (int i = 0; i <= 100; i += 2)
        {
            Console.WriteLine(i);
            Console.ReadKey(true);
       

        }

        }
    }
}
