using System;
using ClasesAbstractasInterfaces;
using Interfaces;

namespace Implemntacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string color = Console.ReadLine();
            Rectangulo rectangulo = new Rectangulo(color, 2.5, 5);

            FormaGeometrica forma = new Rectangulo("amarillo", 3, 8);

            IMedidaCalculable2D medidaCalculable2D = rectangulo;

            Console.WriteLine("El área del rectángulo es {0}",rectangulo.area());
            Console.WriteLine("El perímetro del rectángulo es {0}", rectangulo.perimetro());
            Console.WriteLine(rectangulo.color);

            // Haciendo uso de la variable forma
            Console.WriteLine("El área del rectángulo es {0}", (forma as Rectangulo).area());

            // Haciendo uso de métodos estáticos
            Console.WriteLine("El perímetro de un rectángulo cualquiera es: ", Rectangulo.obtenerPerimetro(8, 10));

        }
    }
}
