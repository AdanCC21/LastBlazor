using Data.IRepository;
using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class PlanMateriaRep : IPlanMateriaRep
    {
        public Task<E_PlanDeMateria> BuscarPlanDeMateria(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPlanDeMateria(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertarPlanDeMateria(E_PlanDeMateria newPlanDeMateria)
        {
            throw new NotImplementedException();
        }

        public Task ModificarPlanDeMateria(int id, E_PlanDeMateria upPlanDeMateria)
        {
            throw new NotImplementedException();
        }

        public Task<List<E_PlanDeMateria>> ObtenerPlanDeMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
