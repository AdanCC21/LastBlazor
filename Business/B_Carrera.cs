using Data.Repository;
using Entitties.Models;

namespace Business
{
    public class B_Carrera(CarreraRep carreraRep)
    {
        readonly private CarreraRep repo = carreraRep;
        public async Task InsertarCarrera(E_Carrera carrera)
        {
            await repo.InsertarCarrera(carrera);
        }

        public async Task EliminarCarrera(int id)
        {
            await repo.EliminarCarrera(id);
        }

        public async Task ModificarCarrera(int id,E_Carrera carrera)
        {
            await repo.ModificarCarrera(id,carrera);
        }

        public async Task<E_Carrera> BuscarCarrera(int id)
        {
            return await repo.BuscarCarrera(id);
        }

        public async Task<List<E_Carrera>> ObtenerCarreras()
        {
            return await repo.ObtenerCarreras();
        }
    }
}
