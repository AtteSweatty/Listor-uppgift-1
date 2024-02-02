using System;
using System.Collections;
using System.Collections.Generic;

namespace Atte
{
    class Program
    {
        static void Main(string[] args)
        {
            var namnLista = new List<string>();

            Console.WriteLine("Skriv in ditt namn");

            while (Console.ReadLine() is { } namn && !string.IsNullOrEmpty(namn))
            {
                namnLista.Add(namn);
            }

            namnLista.Reverse();

            Console.WriteLine("\nNamn i omvänd:");

            foreach (var namn in namnLista)
            {
                Console.WriteLine(namn);
            }
        }
    }
}