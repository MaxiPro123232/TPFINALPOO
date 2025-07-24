using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class ProductoNoEncontradoException : Exception
    {
        public ProductoNoEncontradoException(string mensaje) : base(mensaje) { }
    }

}
