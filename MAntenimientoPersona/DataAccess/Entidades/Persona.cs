using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Persona
    {
        public string nombre { set; get; }
        public string direccion { set; get; }
        public string correoElectronico { set; get; }
        public string telefono { get; set; }
    }
}
