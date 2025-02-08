using System;

class Program
{
    public static void Main()
    {

        Console.WriteLine("Os números primos entre 1 e 100 são:");
        // Comando para verificar todos os números de 1 a 100, iniciando aparir de 2 já que 2 é um número primo
        for (int numero = 2; numero <= 100; numero++)
        {
            bool isPrimo = true;  // Assumimos que o número é primo inicialmente

            // Verifica se o número é menor que 2, que não são primos(1 e <= 0)
            if (numero < 2)
            {
                isPrimo = false;
            }
            else
            {
                // Verifica se o número é divisível por qualquer número entre 2 e a raiz quadrada de 'numero'
                for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        isPrimo = false;  // Se for divisível, não é primo
                        break;
                    }
                }
            }

            // Se o número for primo, imprime na tela
            if (isPrimo)
            {
                Console.WriteLine(numero);
            }
        }
        Console.WriteLine("Este são todos os númeroa primos de 1 a 100!");
        Console.WriteLine("Pressione alguma tecla para sair...");
        Console.ReadLine();
    }
}
