using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class GestorStock
    {
        private RepositorioProductos repoProductos;
        private RepositorioProveedores repoProveedores;
        private RepositorioMovimientosStock repoMovimientos;

        public GestorStock(RepositorioProductos productos, RepositorioProveedores proveedores, RepositorioMovimientosStock movimientos)
        {
            repoProductos = productos;
            repoProveedores = proveedores;
            repoMovimientos = movimientos;
        }

        public void RegistrarIngreso(string codigoProducto, int cantidad, string codigoProveedor, DateTime fecha)
        {
            var producto = repoProductos.BuscarPorCodigo(codigoProducto);
            var proveedor = repoProveedores.BuscarPorCodigo(codigoProveedor);

            if (producto == null)
                throw new Exception("Producto no encontrado.");
            if (proveedor == null)
                throw new Exception("Proveedor no encontrado.");
            if (cantidad <= 0)
                throw new Exception("Cantidad inválida.");

            producto.Stock += cantidad;

            var ingreso = new IngresoStock
            {
                Codigo = Guid.NewGuid().ToString(),
                Producto = producto,
                Cantidad = cantidad,
                Fecha = fecha,
                Proveedor = proveedor
            };

            repoMovimientos.RegistrarMovimiento(ingreso);
        }

        public void RegistrarEgreso(string codigoProducto, int cantidad, string motivo, DateTime fecha)
        {
            var producto = repoProductos.BuscarPorCodigo(codigoProducto);

            if (producto == null)
                throw new Exception("Producto no encontrado.");
            if (cantidad <= 0)
                throw new Exception("Cantidad inválida.");
            if (producto.Stock < cantidad)
                throw new Exception("Stock insuficiente.");

            producto.Stock -= cantidad;

            var egreso = new EgresoStock
            {
                Codigo = Guid.NewGuid().ToString(),
                Producto = producto,
                Cantidad = cantidad,
                Fecha = fecha,
                Motivo = motivo
            };

            repoMovimientos.RegistrarMovimiento(egreso);
        }

        public void DescontarStockDeVencidos()
        {
            var vencidos = repoProductos.ProductosVencidos();
            foreach (var p in vencidos)
            {
                p.Stock = 0;
            }
        }

        public List<Producto> ObtenerProductosPorVencer()
        {
            return repoProductos.ProductosPorVencer();
        }

        public List<Producto> ObtenerProductosBajoStock(int umbral)
        {
            return repoProductos.ProductosBajoStock(umbral);
        }
    }

}
