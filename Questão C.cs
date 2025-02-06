using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
    	Console.WriteLine("Digite uma palavra:");
    	string txt = Console.ReadLine();
      
    	foreach(char letra in txt)
    	{
    	Console.WriteLine(letra);
    	}
   		Console.WriteLine("Este é o comprimento da palavra Digitada! Pressione qualquer tecla para Sair.");
   		Console.ReadKey();
    }
  }
}
