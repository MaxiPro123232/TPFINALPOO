using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class Proveedor
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }

}
