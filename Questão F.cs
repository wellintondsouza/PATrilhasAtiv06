using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números que você deseja inserir: ");
        int quantidade = int.Parse(Console.ReadLine());

        int maiorNumero = int.MinValue; // Inicializa com o menor valor possível

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            int numero = int.Parse(Console.ReadLine());

            if (numero > maiorNumero)
            {
                maiorNumero = numero; // Atualiza o maior número
            }
        }

        Console.WriteLine("O maior número é: {0}", maiorNumero);
        Console.ReadLine();
    }
}
