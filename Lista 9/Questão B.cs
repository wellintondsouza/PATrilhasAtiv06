using System;

class Program
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }

        // Método para calcular a média
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2.0; // Calcula a média das duas notas
        }
    }

    public static void Main()
    {
        // Definindo 5 alunos com suas notas
        Aluno[] alunos = new Aluno[5];

        alunos[0] = new Aluno { Nome = "Marcos", Nota1 = 50, Nota2 = 70 };
        alunos[1] = new Aluno { Nome = "Luan", Nota1 = 40, Nota2 = 10 };
        alunos[2] = new Aluno { Nome = "Kleber", Nota1 = 60, Nota2 = 60 };
        alunos[3] = new Aluno { Nome = "Klebin", Nota1 = 80, Nota2 = 80 };
        alunos[4] = new Aluno { Nome = "Bolneário", Nota1 = 50, Nota2 = 100 };

        // Exibindo os dados dos alunos e suas médias
        Console.WriteLine("Dados dos alunos:");
        for (int i = 0; i < alunos.Length; i++)
        {
            double media = alunos[i].CalcularMedia();
            Console.WriteLine("Nome: {0}, Nota 1: {1}, Nota 2: {2}, Média: {3:F2}", 
                alunos[i].Nome, alunos[i].Nota1, alunos[i].Nota2, media);
        }

        Console.ReadKey(true);
    }
}
