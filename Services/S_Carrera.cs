using Business;
using Entitties.Models;

namespace Services
{
    public class S_Carrera(B_Carrera carreraBus)
    {
        readonly private B_Carrera business = carreraBus;
        public async Task InsertarCarrera(E_Carrera carrera)
        {
            await business.InsertarCarrera(carrera);
        }

        public async Task EliminarCarrera(int id)
        {
            await business.EliminarCarrera(id);
        }

        public async Task ModificarCarrera(int id, E_Carrera carrera)
        {
            await business.ModificarCarrera(id, carrera);
        }

        public async Task<E_Carrera> BuscarCarrera(int id)
        {
            return await business.BuscarCarrera(id);
        }

        public async Task<List<E_Carrera>> ObtenerCarreras()
        {
            return await business.ObtenerCarreras();
        }
    }
}
