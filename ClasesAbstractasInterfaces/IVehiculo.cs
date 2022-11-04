using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractasInterfaces
{
    public interface IVehiculo
    {
        public void encender();

        public void apagar();

        public void acelerar(double velocidad);

        public void girar(string direccion);

        public void cargarCombustible();

        public bool estaEncendido();

        public int aniosDeAntiguedad();
    }
}
