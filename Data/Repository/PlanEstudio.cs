using Data.IRepository;
using Entitties.Models;

namespace Data.Repository
{
    public class PlanEstudio : IPlanDeEstudioRep
    {
        public Task<E_PlanDeEstudio> BuscarPlanDeEstudio(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPlanDeEstudio(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertarPlanDeEstudio(E_PlanDeEstudio newPlanDeEstudio)
        {
            throw new NotImplementedException();
        }

        public Task ModificarPlanDeEstudio(int id, E_PlanDeEstudio upPlanDeEstudio)
        {
            throw new NotImplementedException();
        }

        public Task<List<E_PlanDeEstudio>> ObtenerPlanDeEstudios()
        {
            throw new NotImplementedException();
        }
    }
}
