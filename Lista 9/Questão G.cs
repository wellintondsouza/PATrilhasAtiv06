using System;

class Program
{
    public static void Main()
    {

        double[] num1 = new double[5];
        double[] num2 = new double[5];
        double[] soma = new double[5];

        for (int i = 0; i < 5; i++)
        {


            Console.Write("digite um numero: ");
            num1[i] = double.Parse(Console.ReadLine());

            Console.Write("digite outro numero: ");
            num2[i] = double.Parse(Console.ReadLine());
        }


        for (int i = 0; i < 5; i++)
        {
            double conta = (num1[i] + num2[i]);
            soma[i] += conta;
            Console.WriteLine("A soma de {0} com {1} é igual a : {2}", num1[i], num2[i], soma[i]);
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
