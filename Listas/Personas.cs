using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class MiClase
    {

    }

    public class Persona
    {
        public string nombre { get; set; }
        // Composición
        public MiClase miClase { get; set; }

        public Persona()
        {
            nombre = string.Empty;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
    }
    public class Personas
    {
        private List<Persona> personas = new List<Persona>();

        public Personas() { }

        public Personas(List<Persona> personas)
        {
            this.personas = personas;
        }

        public Personas(Persona[] personas)
        {
            foreach(Persona persona in personas)
            {
                this.personas.Add(persona);
            }
        }

        public void insertarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void removerPersona(Persona persona)
        {
            if (persona == null)
            {
                throw new Exception("Se requiere un valor válido para agregar una persona");
            }
            else if (personas.Contains(persona))
            {
                personas.Remove(persona);
            }
            else
            {
                throw new Exception("Persona no encontrada");
            }
        }
    }
}
