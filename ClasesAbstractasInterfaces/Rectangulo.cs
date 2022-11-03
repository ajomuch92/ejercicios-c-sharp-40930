using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractasInterfaces
{
    public class Rectangulo : FormaGeometrica, IMedidaCalculable2D
    {
        public double Base { get; set; }
        public double altura { get; set; }

        public Rectangulo() { }

        public Rectangulo(string color,double Base, double altura) : base("Rectángulo", 4, color)
        {
            this.Base = Base;
            this.altura = altura;
        }

        public Rectangulo(double Base, double altura) : base()
        {
            this.Base = Base;
            this.altura = altura;
        }

        public virtual double area()
        {
            return Base * altura;
        }

        public string area(string unidades)
        {
            return $"{Base * altura} {unidades} cuadradas";
        }

        public double perimetro()
        {
            return 2 * Base + 2 * altura;
        }

        public override string ToString() // Equals
        {
            return nombre + " " + color;
        }

        /* public override bool Equals(object obj)
        {
            Rectangulo rectangulo = obj as Rectangulo;
            return Base == rectangulo.Base && altura == rectangulo.altura;
        } */

        public bool Equals(Rectangulo rectangulo)
        {
            return Base == rectangulo.Base && altura == rectangulo.altura;
        }

        //Sobreescribiendo un método de la clase base
        public override string representacion()
        {
            return "Este es un rectángulo";
        }

        public static double obtenerPerimetro(double baseRectangulo, double altura)
        {
            return 2 * baseRectangulo + 2 * altura;
        }

        public override double dobleArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Cuadrado : Rectangulo
    {
        public double lado { get; set; }

        public Cuadrado() : base() { }

        public Cuadrado(double lado) : base(lado, lado)
        {
            this.lado = lado;
        }

        public override double area()
        {
            return lado * lado;
        }
    }

    public class Circulo : FormaGeometrica, IMedidaCalculable2D
    {
        public double radio { get; set; }

        public Circulo() { }

        public Circulo(double radio)
        {
            this.radio = radio;
        }


        public double area()
        {
            return Math.PI * radio * radio;
        }

        public double perimetro()
        {
            return 2 * radio * Math.PI;
        }

        public override double dobleArea()
        {
            throw new NotImplementedException();
        }
    }
}
