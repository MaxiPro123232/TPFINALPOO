using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public abstract class MovimientoStock
    {
        public string Codigo { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public abstract string TipoMovimiento { get; }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy} - {TipoMovimiento} - {Producto.Nombre} - Cantidad: {Cantidad}";
        }
    }

}
