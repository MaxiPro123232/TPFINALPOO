using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class EgresoStock : MovimientoStock
    {
        public string Motivo { get; set; } // Venta, merma, devolución, etc.

        public override string TipoMovimiento => "Egreso";
    }

}
