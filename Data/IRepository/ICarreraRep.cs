using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface ICarreraRep
    {
        public Task InsertarCarrera(E_Carrera newCarrera);
        public Task EliminarCarrera(int id);
        public Task ModificarCarrera(int id, E_Carrera upCarrera);
        public Task<E_Carrera> BuscarCarrera(int id);
        public Task<List<E_Carrera>> ObtenerCarreras();
    }
}
