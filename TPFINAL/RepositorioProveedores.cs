using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class RepositorioProveedores
    {
        private List<Proveedor> proveedores;

        public RepositorioProveedores()
        {
            proveedores = new List<Proveedor>();
        }

        public void Agregar(Proveedor proveedor)
        {
            if (proveedor == null)
                throw new ArgumentException("El proveedor no puede ser nulo.");

            if (BuscarPorCodigo(proveedor.Codigo) != null)
                throw new Exception("Ya existe un proveedor con ese código.");

            proveedores.Add(proveedor);
        }

        public Proveedor BuscarPorCodigo(string codigo)
        {
            return proveedores.FirstOrDefault(p => p.Codigo == codigo);
        }

        public List<Proveedor> BuscarPorNombre(string nombre)
        {
            return proveedores.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
        }

        public List<Proveedor> ListarTodos()
        {
            return proveedores.ToList();
        }

        public void Eliminar(string codigo)
        {
            var proveedor = BuscarPorCodigo(codigo);
            if (proveedor != null)
                proveedores.Remove(proveedor);
        }
    }

}
