using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    interface IAreaConocimientoRep
    {
        public Task InsertarAC(E_AreaDeConocimiento newAC);
        public Task EliminarAC(int id);
        public Task ModificarAC(int id, E_AreaDeConocimiento upAC);
        public Task<E_AreaDeConocimiento> BuscarAC(int id);
        public Task<List<E_AreaDeConocimiento>> ObtenerACs();
    }
}
