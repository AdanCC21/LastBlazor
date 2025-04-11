using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IPlanDePlanDeMateria
    {
        public Task InsertarPlanDeMateria(E_PlanDeMateria newPlanDeMateria);
        public Task EliminarPlanDeMateria(int id);
        public Task ModificarPlanDeMateria(int id, E_PlanDeMateria upPlanDeMateria);
        public Task<E_PlanDeMateria> BuscarPlanDeMateria(int id);
        public Task<List<E_PlanDeMateria>> ObtenerPlanDeMaterias();
    }
}
