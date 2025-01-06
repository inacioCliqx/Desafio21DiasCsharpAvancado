using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            var gol = new GolQuadradoMil();
            gol.Marca = "Gol";
            gol.Ano = 1996;
            gol.Nome = "Gol Quadrado 1000";

            Console.WriteLine(gol.ToString());
            gol.Salvar();

            Console.Read();
        }
    }
}
