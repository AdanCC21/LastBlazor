using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IMateriaRep
    {
        public Task InsertarMateria(E_Materia newMateria);
        public Task EliminarMateria(int id);
        public Task ModificarMateria(int id, E_Materia upMateria);
        public Task<E_Materia> BuscarMateria(int id);
        public Task<List<E_Materia>> ObtenerMaterias();
    }
}
