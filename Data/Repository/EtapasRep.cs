using Data.IRepository;
using Entitties.Models;

namespace Data.Repository
{
    public class EtapasRep : IEtapasRep
    {
        public Task<E_Etapa> BuscarEtapa(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarEtapa(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertarEtapa(E_Etapa newEtapa)
        {
            throw new NotImplementedException();
        }

        public Task ModificarEtapa(int id, E_Etapa upEtapa)
        {
            throw new NotImplementedException();
        }

        public Task<List<E_Etapa>> ObtenerEtapas()
        {
            throw new NotImplementedException();
        }
    }
}
