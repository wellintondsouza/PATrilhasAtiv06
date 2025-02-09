using System;
    class Program
    {
        static void Main()
        {

            double[] notas = { 40, 60, 80, 30, 35, 40 };
            double soma = 0;


            for (int i = 0; i < notas.Length; i++)
                soma += notas[i];
            {
                double media = soma / notas.Length;

                Console.WriteLine("A média das notas é:" +media);
            }
        }
    }