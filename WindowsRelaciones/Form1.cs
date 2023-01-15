using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFactura.Entidad;

namespace WindowsRelaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarProductos(object sender, EventArgs e)
        {
            //foreach (var item in Lista.Listar())
            //{
            //listProducts.Items.Add(item.Categoria.Nombre);
            //}

            Categoria categoria1 = new Categoria("Ropa");
            Categoria categoria2 = new Categoria("Calzado");

            //Console.WriteLine(categoria1.Nombre);

            Producto producto1 = new Producto("Pantalón", 6000.50)
            {
                Categoria = categoria1
            };
            Producto producto2 = new Producto("Zapatillas", 12000.50) 
            {
                Categoria = categoria2
            };

            List<Producto> listaProductos = new List<Producto>();

            listaProductos.Add(producto1);
            listaProductos.Add(producto2);

            foreach (Producto producto in listaProductos)
            {
                listProducts.Items.Add(producto);
            }


        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
