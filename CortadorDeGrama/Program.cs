using CortadorDeGrama.ambiente;
using System;

namespace CortadorDeGrama
{
    class Program
    {

        static void Main(string[] args)
        {
            var laberinto = new Labirinto(3);

            laberinto.exibirLabirinto();

            Console.ReadKey();
        }
    }
}
