using System;

namespace ClasesAbstractasInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string color = Console.ReadLine();
            Rectangulo rectangulo = new Rectangulo(color, 2.5, 5);

            FormaGeometrica forma = new Rectangulo("amarillo", 3, 8);

            IMedidaCalculable2D medidaCalculable2D = rectangulo;

            Console.WriteLine("El área del rectángulo es {0}", rectangulo.area());
            Console.WriteLine("El perímetro del rectángulo es {0}", rectangulo.perimetro());
            Console.WriteLine(rectangulo.color);

            // Haciendo uso de la variable forma
            Console.WriteLine("El área del rectángulo es {0}", (forma as Rectangulo).area());

            // Haciendo uso de métodos estáticos
            Console.WriteLine("El perímetro de un rectángulo cualquiera es: ", Rectangulo.obtenerPerimetro(8, 10)); */

            try
            {
                Motocicleta motoMami = new Motocicleta(color: Colores.azul, marca: "Suzuki", anioLiberacion: 2016,
                    modelo: "Todo terreno",
                    tipoGasolina: "Nafta",
                    placa: "1111-1111",
                    numeroCasco: 10,
                    rodado: "90",
                    tipoRueda: "Dentada",
                    tamanio: "Mediana",
                    maximoOcupantes: 2
                );

                motoMami.encender();

                motoMami.andar();

                motoMami.acelerar(85.7);

                Console.WriteLine(motoMami.ACuantoVoy());

                motoMami.cargarCombustible();

                Console.WriteLine("Años de antigüedad {0}", motoMami.aniosDeAntiguedad());

                motoMami.girar("centro");

                motoMami.apagar();
            }
            catch(Exception ex)
            {
                Console.WriteLine("===================");
                Console.WriteLine(ex.Message);
                Console.WriteLine("===================");
            }

        }
    }
}
