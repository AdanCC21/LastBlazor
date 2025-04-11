using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    interface IEtapasRep
    {
        public Task InsertarEtapa(E_Etapa newEtapa);
        public Task EliminarEtapa(int id);
        public Task ModificarEtapa(int id, E_Etapa upEtapa);
        public Task<E_Etapa> BuscarEtapa(int id);
        public Task<List<E_Etapa>> ObtenerEtapas();
    }
}
