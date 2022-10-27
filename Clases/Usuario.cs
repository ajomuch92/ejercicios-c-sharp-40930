using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public short edad { get; set; }
        public string domicilio { get; set; }

        public Usuario()
        {
            nombre = "";
            apellido = "";
            dni = "";
            email = "";
            edad = 0;
            domicilio = "";
        }

        public Usuario(string nombre, string apellido, string dni, string email, short edad, string domicilio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.email = email;
            this.edad = edad;
            this.domicilio = domicilio;
        }

        public bool esMayorEdad()
        {
            return edad >= 18;
        }

        public void cambiarDireccion(string nuevoDomicilio)
        {
            domicilio = nuevoDomicilio;
        }

        public bool esGmail()
        {
            return email.ToLower().Contains("gmail");
        }
    }
}
