
using System;
class Program
{
   public static void Main()
    {
        Console.WriteLine("Digite um numero:");
        int numero = int.Parse(Console.ReadLine());


        bool isPrimo = true;
        
        if (numero < 2)
       { 
        isPrimo = false;
        }
        
        else 
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            { 
            if (numero % i == 0)
              {
                    isPrimo = false;
                    break;
                
                }

            }
        }
        if (isPrimo)
        {
            Console.WriteLine("O número {0} é primo.", numero);

        }
        else 
        {
            Console.WriteLine("O número {0} não é primo.", numero);
           
        }
        Console.ReadLine();
    }
}


