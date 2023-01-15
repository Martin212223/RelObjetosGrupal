using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public abstract class Persona
    {
        public Persona(string apellido, string nombre, string dNI)
        {
            Apellido = apellido;
            Nombre = nombre;
            DNI = dNI;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
    }
}
