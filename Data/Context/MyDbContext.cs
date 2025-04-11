using Microsoft.EntityFrameworkCore;
using Entitties.Models;

namespace Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<E_Carrera> Carrera { get; set; }
        public DbSet<E_Materia> Materias { get; set; }
        public DbSet<E_PlanDeEstudio> PlanDeEstudios { get; set; }
        public DbSet<E_PlaneDeMateria> PlanDeEstudiosMaterias { get; set; }
    }
}
