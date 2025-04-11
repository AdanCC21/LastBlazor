using Data.Context;
using Data.IRepository;
using Entitties.Models;
using Microsoft.EntityFrameworkCore;


namespace Data.Repository
{
    public class MateriaRep(MyDbContext contextBD) : IMateriaRep
    {
        readonly private MyDbContext context = contextBD;
        public async Task<E_Materia> BuscarMateria(int id)
        {
            var Materia = await this.context.Materias.FindAsync(id) ?? throw new Exception("Materia no encontrada");
            return Materia;
        }

        public async Task EliminarMateria(int id)
        {
            try
            {
                var Materia = await this.context.Materias.FindAsync(id) ?? throw new Exception("Materia no encontrada");
                this.context.Materias.Remove(Materia);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task InsertarMateria(E_Materia newMateria)
        {
            try
            {
                await context.Materias.AddAsync(newMateria);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task ModificarMateria(int id, E_Materia upMateria)
        {
            try
            {
                var Materia = await this.context.Materias.FindAsync(id) ?? throw new Exception("Materia no encontrada");
                this.context.Materias.Update(upMateria);
                await this.context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<E_Materia>> ObtenerMaterias()
        {
            return await this.context.Materias.ToListAsync();
        }
    }
}
