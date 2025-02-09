using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pressione uma tecla para ver a média das notas.");
        Console.ReadKey();
        
        double[]  notas = {40, 60, 30, 40, 80};
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
            soma += notas[i];
        {
            double media = soma / notas.Length;
            Console.WriteLine("A media das notas é:" +media);
        
        }
    
    }
}
