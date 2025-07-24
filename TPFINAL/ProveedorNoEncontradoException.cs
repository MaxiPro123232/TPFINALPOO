using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class ProveedorNoEncontradoException : Exception
    {
        public ProveedorNoEncontradoException(string mensaje) : base(mensaje) { }
    }

}
