using LibFactura.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Cliente : Persona
    {
        public Cliente(string apellido, string nombre, string dNI, string telefono) : base(apellido, nombre, dNI)
        {
            Telefono = telefono;            
        }

        public List<Factura> LstFacturas { get; set; }
        public Usuario Usuario { get; set; }
        public string Telefono { get; set; }
    }
}
