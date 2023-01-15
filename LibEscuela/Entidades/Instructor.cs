using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEscuela.Entidades
{
    public class Instructor:Persona
    {
        public List<Materia>Materias{ get; set; }
    }
}
