using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractasInterfaces
{
    public class Motocicleta : VehiculoAutomotor
    {
        public short numeroCasco { get; set; }
        public string rodado { get; set; }
        public string tipoRueda { get; set; }
        public string tamanio { get; set; }
        public short maximoOcupantes { get; set; }

        public Motocicleta(string color, 
            string marca, 
            string modelo,
            int anioLiberacion,
            string tipoGasolina,
            string placa,
            short numeroCasco, 
            string rodado, 
            string tipoRueda, 
            string tamanio, 
            short maximoOcupantes
        ) : base(color, marca, modelo, anioLiberacion, 0, tipoGasolina, placa)
        {
            this.numeroCasco = numeroCasco;
            this.rodado = rodado;
            this.tipoRueda = tipoRueda;
            this.tamanio = tamanio;
            this.maximoOcupantes = maximoOcupantes;
        }

        public Motocicleta() : base() { }

        public override void andar()
        {
            Console.WriteLine("Andando en 2 ruedas...");
        }
    }
}
