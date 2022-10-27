using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public double IVA { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaVencimiento { get; set; }

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public Producto()
        {
            codigo = 0;
            descripcion = "";
            precioCompra = 0;
            precioVenta = 0;
            categoria = "";
            proveedor = "";
            IVA = 0;
            cantidad = 0;
            fechaVencimiento = DateTime.Now;
        }

        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria, string proveedor, double IVA, int cantidad, DateTime fechaVencimiento)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.categoria = categoria;
            this.proveedor = proveedor;
            this.IVA = IVA;
            this.cantidad = cantidad;
            this.fechaVencimiento = fechaVencimiento;
        }

        public Producto(int codigo)
        {
            this.codigo = codigo;
        }

        public void descontarInventario(int cantidad)
        {
            this.cantidad -= cantidad;
            this.cantidad--;
        }

        public double agregarDescuento(double porcentajeDescuento)
        {
            return precioVenta - precioVenta * (porcentajeDescuento / 100);
        }

        public double agregarDescuento(int porcentajeDescuento)
        {
            return precioVenta - precioVenta * (porcentajeDescuento / 100);
        }

        public bool tienePrecio()
        {
            return precioVenta > 0;
        }

        override
        public string ToString()
        {
            return descripcion;
        }
    }

    public class Persona
    {

    }
}
