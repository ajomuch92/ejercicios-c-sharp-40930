using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionBaseDeDatos
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }
    }

    public class Producto
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public string Categoria { get; set; }

        public Producto()
        {

        }

        public Producto(long id, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            Id = id;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Categoria = categoria;
        }
    }
}
