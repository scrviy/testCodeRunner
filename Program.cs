using System;

namespace TestCodeRunner
{
    public class TestCodeRunner
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            string? nome, sobrenome;
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
        }
    }
}