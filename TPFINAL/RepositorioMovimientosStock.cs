using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class RepositorioMovimientosStock
    {
        private List<MovimientoStock> movimientos;

        public RepositorioMovimientosStock()
        {
            movimientos = new List<MovimientoStock>();
        }

        public void RegistrarMovimiento(MovimientoStock movimiento)
        {
            if (movimiento == null)
                throw new ArgumentException("El movimiento no puede ser nulo.");

            movimientos.Add(movimiento);
        }

        public List<MovimientoStock> ListarTodos()
        {
            return movimientos.ToList();
        }

        public List<MovimientoStock> FiltrarPorProducto(string codigoProducto)
        {
            return movimientos.Where(m => m.Producto.Codigo == codigoProducto).ToList();
        }

        public List<MovimientoStock> FiltrarPorTipo(string tipo)
        {
            return movimientos.Where(m => m.TipoMovimiento == tipo).ToList();
        }

        public List<MovimientoStock> FiltrarPorFecha(DateTime desde, DateTime hasta)
        {
            return movimientos.Where(m => m.Fecha.Date >= desde.Date && m.Fecha.Date <= hasta.Date).ToList();
        }

        public List<MovimientoStock> MovimientosPorProveedor(string codigoProveedor)
        {
            return movimientos
                .OfType<IngresoStock>()
                .Where(i => i.Proveedor?.Codigo == codigoProveedor)
                .Cast<MovimientoStock>()
                .ToList();
        }

        public List<MovimientoStock> HistorialProducto(string codigoProducto)
        {
            return movimientos.Where(m => m.Producto.Codigo == codigoProducto).OrderBy(m => m.Fecha).ToList();
        }
    }

}
