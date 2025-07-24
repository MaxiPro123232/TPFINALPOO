using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta => PrecioCompra * 1.5m; 
        public int Stock { get; set; }
        public Rubro Rubro { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public bool EstaVencido()
        {
            return FechaVencimiento.Date < DateTime.Today;
        }

        public bool PorVencer()
        {
            return FechaVencimiento.Date <= DateTime.Today.AddDays(7);
        }
    }

}
