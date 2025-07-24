using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL
{
    public class RepositorioRubros
    {
        private List<Rubro> rubros;

        public RepositorioRubros()
        {
            rubros = new List<Rubro>();
        }

        public void Agregar(Rubro rubro)
        {
            if (rubro == null)
                throw new ArgumentException("El rubro no puede ser nulo.");

            if (BuscarPorCodigo(rubro.Codigo) != null)
                throw new Exception("Ya existe un rubro con ese código.");

            rubros.Add(rubro);
        }

        public Rubro BuscarPorCodigo(string codigo)
        {
            return rubros.FirstOrDefault(r => r.Codigo == codigo);
        }

        public List<Rubro> ListarTodos()
        {
            return rubros.ToList();
        }

        public void Eliminar(string codigo)
        {
            var rubro = BuscarPorCodigo(codigo);
            if (rubro != null)
                rubros.Remove(rubro);
        }
    }

}
