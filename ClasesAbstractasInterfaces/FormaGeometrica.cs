using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractasInterfaces
{
    public abstract class FormaGeometrica
    {
        public string nombre { get; set; }
        public int cantidadLados { get; set; }
        public string color { get; set; }

        public FormaGeometrica() { }

        public FormaGeometrica (string nombre, int cantidadLados, string color)
        {
            this.nombre = nombre;
            this.cantidadLados = cantidadLados;
            this.color = color;
        }

        public abstract double dobleArea();

        public virtual string representacion()
        {
            return "Esta es una figura geométrica";
        }
    }
}
