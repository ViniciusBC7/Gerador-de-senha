using System;
using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(args[0]);
            string caracteresPossiveis = "ABCDEFGHIJKLMNOPQRSTUVZXYZÇ" + "ABCDEFGHIJKLMNOPQRSTUVZXYZÇ".ToLower() +
            "0123456789" + "!@#$%";

            Random sorteio = new Random();
            int numeroSorteio = 0;
            StringBuilder password = new StringBuilder();

            for (int t = 0; t < qtd; t++)
            {
                numeroSorteio = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteio]);
            }
            Console.WriteLine();
            Console.Write(password);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}