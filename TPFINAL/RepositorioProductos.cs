using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class RepositorioProductos
    {
        private List<Producto> productos;

        public RepositorioProductos()
        {
            productos = new List<Producto>();
        }

        public void Agregar(Producto producto)
        {
            if (producto == null)
                throw new ArgumentException("El producto no puede ser nulo.");

            if (BuscarPorCodigo(producto.Codigo) != null)
                throw new Exception("Ya existe un producto con ese código.");

            productos.Add(producto);
        }

        public Producto BuscarPorCodigo(string codigo)
        {
            return productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return productos.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
        }

        public List<Producto> FiltrarPorRubro(Rubro rubro)
        {
            return productos.Where(p => p.Rubro?.Codigo == rubro.Codigo).ToList();
        }

        public void Eliminar(string codigo)
        {
            var producto = BuscarPorCodigo(codigo);
            if (producto != null)
                productos.Remove(producto);
        }

        public List<Producto> ListarTodos()
        {
            return productos.ToList(); 
        }

        public List<Producto> ProductosPorVencer()
        {
            return productos.Where(p => p.PorVencer()).ToList();
        }

        public List<Producto> ProductosVencidos()
        {
            return productos.Where(p => p.EstaVencido()).ToList();
        }

        public List<Producto> ProductosBajoStock(int umbral)
        {
            return productos.Where(p => p.Stock < umbral).ToList();
        }
    }

}
