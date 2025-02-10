using System;
using System.Collections.Generic;

class Program
{
    class Mercadoria
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal ValorTotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }

    static void Main()
    {
        List<Mercadoria> estoque = new List<Mercadoria>();
        int opcao;

        do
        {
            // Exibe o menu
            Console.WriteLine("MENU");
            Console.WriteLine("1. Cadastrar mercadorias");
            Console.WriteLine("2. Exibir valor total em mercadorias da empresa");
            Console.WriteLine("3. Sair");
            Console.Write("OPÇÃO: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarMercadorias(estoque);
                    break;
                case 2:
                    ExibirValorTotal(estoque);
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 3);
    }

    static void CadastrarMercadorias(List<Mercadoria> estoque)
    {
        if (estoque.Count >= 40)
        {
            Console.WriteLine("Limite de mercadorias atingido. Não é possível cadastrar mais.");
            return;
        }

        Mercadoria mercadoria = new Mercadoria();

        Console.Write("Digite o nome da mercadoria: ");
        mercadoria.Nome = Console.ReadLine();

        Console.Write("Digite a quantidade em estoque: ");
        mercadoria.Quantidade = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço unitário: ");
        mercadoria.PrecoUnitario = decimal.Parse(Console.ReadLine());

        estoque.Add(mercadoria);
        Console.WriteLine("Mercadoria cadastrada com sucesso!");
    }

    static void ExibirValorTotal(List<Mercadoria> estoque)
    {
        decimal valorTotal = 0;

        foreach (var mercadoria in estoque)
        {
            valorTotal += mercadoria.ValorTotal();
        }

        Console.WriteLine($"Valor total em mercadorias: R$ {valorTotal:F2}");
    }
}
