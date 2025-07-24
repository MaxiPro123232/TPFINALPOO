using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class IngresoStock : MovimientoStock
    {
        public Proveedor Proveedor { get; set; }

        public override string TipoMovimiento => "Ingreso";
    }

}
