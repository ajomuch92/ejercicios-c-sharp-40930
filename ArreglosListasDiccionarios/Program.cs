using System;
using System.Collections.Generic;

namespace ArreglosListasDiccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] razasDePerros = new string[5];
            int[] edades = { 20, 35, 48, 10, 7};
            int indice = 0;
            foreach(string raza in razasDePerros)
            {
                razasDePerros[indice] = Console.ReadLine();
                indice++;
            }
            foreach(int edad in edades)
            {
                Console.WriteLine(edad);
            }
            for(int i = 0; i < razasDePerros.Length; i++)
            {
                Console.WriteLine(razasDePerros[i]);
            }
            Console.WriteLine(razasDePerros.Length); */

            /* Botella[] botellas = new Botella[3];
            Botella[] botellas1 =
            {
                new Botella("Coca Cola"),
                new Botella("Pepsi"),
                new Botella("Sprite")
            };
            foreach(Botella botella in botellas1)
            {
                Console.WriteLine(botella);
            }

            Botella[] botellitas = 
            {
                new Botellita("Coca Cola"),
                new Botellita("Pepsi"),
                new Botellita("Sprite")
            }; */

            Dictionary<string, Persona> personas = new Dictionary<string, Persona>();
            personas.Add("41452092", new Persona("Francis Zerbo"));
            personas.Add("33790264", new Persona("Matias Di Giovanni"));
            personas.Add("18866256", new Persona("Peter James"));
            personas.Add("1", new Persona("Jane Doe"));
            Console.WriteLine("Count");
            Console.WriteLine(personas.Count);
            Console.WriteLine("Claves");
            Console.WriteLine(personas.Keys);
            Console.WriteLine("Valores");
            Console.WriteLine(personas.Values);
            personas.Remove("1");
            Console.WriteLine("Despues de remover");
            Console.WriteLine(personas.Count);
            Console.WriteLine("Ingrese una clave a eliminar");
            String llaveAEliminar = Console.ReadLine();
            if (personas.ContainsKey(llaveAEliminar))
            {
                personas.Remove(llaveAEliminar);
            }
            Persona value = new Persona();
            personas.TryGetValue("0", out value);
            Console.WriteLine("Variable de salida");
            Console.WriteLine(value);

            foreach(string key in personas.Keys)
            {
                Console.WriteLine(personas[key]);
            }
            personas.Clear();
            Console.WriteLine("Después de limpiar");
            Console.WriteLine(personas.Count);

            Dictionary<string, Dictionary<string, double>> precios = new Dictionary<string, Dictionary<string, double>>();
            
            precios.Add("Bebidas", new Dictionary<string, double>()
            {
                { "JUGO", 14.5 } ,
                { "CERVEZA", 15.6 }
            });
        }
    }
}
