using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractasInterfaces
{
    public class VehiculoAutomotor : IVehiculo
    {
        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anioLiberacion { get; set; }
        public short cantidadPuertas { get; set; }

        public string tipoGasolina { get; set; }
        public string placa { get; set; }
        private bool encendido { get; set; }
        private double velocidad { get; set; }

        public VehiculoAutomotor(string color, string marca, string modelo, int anioLiberacion, short cantidadPuertas, string tipoGasolina, string placa)
        {
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
            this.anioLiberacion = anioLiberacion;
            this.cantidadPuertas = cantidadPuertas;
            this.tipoGasolina = tipoGasolina;
            this.placa = placa;
            encendido = false;
        }

        public VehiculoAutomotor() 
        {
            encendido = false;
        }

        public void encender()
        {
            Console.WriteLine("Encendiendo...");
            encendido = true;
        }

        public void apagar()
        {
            Console.WriteLine("Apagando...");
            encendido = false;
        }

        public void acelerar(double velocidad)
        {
            this.velocidad = velocidad;
            Console.WriteLine("Acelerando...");
        }

        public string ACuantoVoy()
        {
            return $"Mi velocidad es {velocidad}km/h";
        }


        public virtual void andar()
        {
            Console.WriteLine("Apagando...");
        }

        public void girar(string direccion)
        {
            if (direccion.ToLower() != "izquierda" && direccion.ToLower() != "derecha")
            {
                throw new Exception("No se permite otro tipo de dirección");
            }
            Console.WriteLine("Girando hacia {0}", direccion);
        }

        public void cargarCombustible()
        {
            Console.WriteLine("Cargando combustible...");
        }

        public bool estaEncendido()
        {
            return encendido;
        }

        public int aniosDeAntiguedad()
        {
            return DateTime.Now.Year - anioLiberacion;
        }
    }
}
