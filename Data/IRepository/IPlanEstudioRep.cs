using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    interface IPlanDeEstudioRep
    {
        public Task InsertarPlanDeEstudio(E_PlanDeEstudio newPlanDeEstudio);
        public Task EliminarPlanDeEstudio(int id);
        public Task ModificarPlanDeEstudio(int id, E_PlanDeEstudio upPlanDeEstudio);
        public Task<E_PlanDeEstudio> BuscarPlanDeEstudio(int id);
        public Task<List<E_PlanDeEstudio>> ObtenerPlanDeEstudios();
    }
}
