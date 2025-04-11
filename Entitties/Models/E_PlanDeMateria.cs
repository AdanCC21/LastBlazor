using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitties.Models
{
    public class E_PlanDeMateria
    {
        [Key]
        public int IdPlanEstudioMateria { get; set; }

        [ForeignKey("PlanEstudio")]
        public int IdPlanEstudio { get; set; }

        [ForeignKey("Materias")]
        public int IdMateria { get; set; }

        public int IdTipoMateria { get; set; }

        [ForeignKey("Etapas")]
        public int IdEtapa { get; set; }

        [ForeignKey("AreaConocimiento")]
        public int IdAreaConocimiento { get; set; }

        public int IdSeriacion { get; set; }

        public int Semestre { get; set; }

        public string? Estatus { get; set; }

        // Navigation
        public E_PlanDeEstudio PlanEstudio { get; set; } = null!;
        public E_Materia Materias { get; set; } = null!;
        public E_Etapa Etapas { get; set; } = null!;
        public E_AreaDeConocimiento AreaConocimiento { get; set; } = null!;
    }
}
