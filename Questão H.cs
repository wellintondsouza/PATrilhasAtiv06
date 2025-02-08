using System;

class Program
{
    public static void Main()
    {
        Console.Write("Digite o número para motrar seus divisores:");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
            Console.WriteLine("Digite um número válido.");

        }

        Console.WriteLine("Os divisores do número {0} é:", numero);

        //exibe a divisão dos números:
        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);

            }
            
        }
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    }
