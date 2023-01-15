using LibFactura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidad
{
    public class Factura
    {
        public Factura(string tipo)
        {
            Tipo = tipo;            
        }

        public string Tipo { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
    }
}
