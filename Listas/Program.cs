using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> nombres = new List<string> { "Lucas", "Matias", "Adrian"};
            Console.WriteLine($"Capacidad de la lista {nombres.Capacity}");
            Console.WriteLine("Escribe tu nombre");
            string miNombre = Console.ReadLine();
            Console.WriteLine("Antes de agregar");
            Console.WriteLine(nombres.Count);
            nombres.Add(miNombre);
            Console.WriteLine("Después de agregar");
            Console.WriteLine(nombres.Count);
            Console.WriteLine("Recorriendo la lista");
            foreach(string nombre in nombres)
            {
                Console.WriteLine("Hola {0} :)", nombre);
            }
            Console.WriteLine("Insertando");
            nombres.Insert(1, "Camila");
            Console.WriteLine(nombres.Count);
            Console.WriteLine("Removiendo");
            nombres.Remove("Adrian");
            Console.WriteLine($"Capacidad de la lista {nombres.Capacity}");
            Console.WriteLine(nombres.Count);
            bool contieneNombreLucas = nombres.Contains("Lucas");
            Console.WriteLine(contieneNombreLucas);
            int indiceMatias = nombres.IndexOf("Matias");
            Console.WriteLine(indiceMatias);
            nombres.Sort();
            foreach (string nombre in nombres)
            {
                Console.WriteLine("{0} :)", nombre);
            }
            Console.WriteLine("Limpiando lista");
            nombres.Clear();
            Console.WriteLine(nombres.Count);*/

            int[,] numeros = new int[3, 3] { {1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"i: {i} j:{j} valor {numeros[i, j]}");
                }
            }
        }
    }
}
