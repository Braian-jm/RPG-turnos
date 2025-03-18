using System;
using System.Security.Cryptography.X509Certificates;

namespace RPGPorTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Console.WriteLine("                          RPG DO TERMINAL                         ");
            Console.WriteLine("");
            Console.WriteLine("[1] - Novo Jogo");
            Console.WriteLine("[2] - quit");
            escolha = Console.ReadLine();
            if (escolha == "1")
            {
                Personagem Char = new Personagem();
                Char.criacaoPersonagem();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}