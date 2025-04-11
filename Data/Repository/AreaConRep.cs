using Data.IRepository;
using Entitties.Models;

namespace Data.Repository
{
    public class AreaConRep : IAreaConocimientoRep
    {
        public Task<E_AreaDeConocimiento> BuscarAC(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAC(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertarAC(E_AreaDeConocimiento newAC)
        {
            throw new NotImplementedException();
        }

        public Task ModificarAC(int id, E_AreaDeConocimiento upAC)
        {
            throw new NotImplementedException();
        }

        public Task<List<E_AreaDeConocimiento>> ObtenerACs()
        {
            throw new NotImplementedException();
        }
    }
}
