using LibFactura.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Empleado : Persona
    {
        public Empleado(string apellido, string nombre, string dNI, string legajo) : base(apellido, nombre, dNI)
        {
            Legajo = legajo;
        }

        public List<Factura> Facturas { get; set; }
        public string Legajo { get; set; }
    }
}
