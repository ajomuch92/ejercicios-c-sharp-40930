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

        public Usuario() { }

        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Mail = mail;
        }
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

        public Producto(long codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Categoria = categoria;
        }
    }
}
