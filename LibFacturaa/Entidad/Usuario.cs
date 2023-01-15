using LibFactura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidad
{
    public class Usuario 
    {
        public Usuario(string password)
        {            
            Password = password;
        }
        public Cliente Cliente { get; set; }
        public string Password { get; set; }
    }
}
