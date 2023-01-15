using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidad
{
    public class Producto 
    {
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;            
        }

        public string Nombre { get; set; }
        public double Precio { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return "•Nombre: " + Nombre + "  •Precio: " + Precio + "  •Categoría: " + Categoria.Nombre;
        }
    }
}
