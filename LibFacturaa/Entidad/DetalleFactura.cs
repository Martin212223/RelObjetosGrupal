using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidad
{
    public class DetalleFactura
    {
        public DetalleFactura(int cantidad)
        {
            Cantidad = cantidad;                        
        }

        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }
    }
}

