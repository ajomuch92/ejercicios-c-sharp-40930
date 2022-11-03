using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosListasDiccionarios
{
    public class Botella
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public double capacidad { get; set; }

        public Botella() { }

        public Botella(string nombre)
        {
            this.nombre = nombre;
        }

        public Botella(string nombre, string color, double capacidad)
        {
            this.nombre = nombre;
            this.color = color;
            this.capacidad = capacidad;
        }

        public override string ToString()
        {
            return nombre;
        }
    }

    public class Botellita: Botella
    {
        public string material { get; set; }

        public Botellita() : base() { }

        public Botellita(string material)
        {
            this.material = material;
        }

        public Botellita(string nombre, string color, double capacidad, string material) : base(nombre, color, capacidad)
        {
            this.material = material;
        }
    }

    public class Persona
    {
        public string nombre { get; set; }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona() { }

        public override string ToString()
        {
            return nombre;
        }
    }
}