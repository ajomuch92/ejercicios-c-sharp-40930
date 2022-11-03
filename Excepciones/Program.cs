using System;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa un número: ");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa un número: ");
                double numero2 = double.Parse(Console.ReadLine());
                if (numero1 == numero2)
                {
                    throw new MiError("Los números no pueden ser iguales");
                }
                int division = (int)numero1 / (int)numero2;
                Console.WriteLine(division);
            }
            catch (MiError ex)
            {
                Console.WriteLine(ex.Mensaje);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class MiError : Exception
    {
        public string Mensaje { get; set; }

        public MiError(string mensaje)
        {
            Mensaje = mensaje;
        }

        public MiError() { }
    }
}
