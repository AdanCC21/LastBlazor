using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_PlaneDeMateria
    {
        //(IdPlanEstudioMateria, PlanEstudioId, MateriaId, Semestre, PlanEstudio, IdMateria,
        [Key]
        public int idPlanEstudioMateria { get; set; }
        public int planEstudioId { get; set; }
        public int materiaId { get; set; }
        public int semestre { get; set; }
        public string? planEstudio { get; set; }
        public int idMateria { get; set; }
    }
}
