using Data.Context;
using Data.IRepository;
using Entitties.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Data.Repository
{
    public class CarreraRep(MyDbContext contextBD) : ICarreraRep
    {
        readonly private MyDbContext context = contextBD;
        public async Task<E_Carrera> BuscarCarrera(int id)
        {
            var carrera = await this.context.Carrera.FindAsync(id) ?? throw new Exception("Carrera no encontrada");
            return carrera;
        }

        public async Task EliminarCarrera(int id)
        {
            try
            {
                var carrera = await this.context.Carrera.FindAsync(id) ?? throw new Exception("Carrera no encontrada");
                this.context.Carrera.Remove(carrera);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task InsertarCarrera(E_Carrera newCarrera)
        {
            try
            {
                await context.Carrera.AddAsync(newCarrera);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task ModificarCarrera(int id, E_Carrera upCarrera)
        {
            try
            {
                var carrera = await this.context.Carrera.FindAsync(id) ?? throw new Exception("Carrera no encontrada");
                this.context.Carrera.Update(upCarrera);
                await this.context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<E_Carrera>> ObtenerCarreras()
        {
            return await this.context.Carrera.ToListAsync();
        }
    }
}
