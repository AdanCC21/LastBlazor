using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitties.Models
{
    public class E_PlanDeEstudio
    {
        [Key]
        public int IdPlanEstudio { get; set; }

        [ForeignKey("Carreras")]
        public int IdCarrera { get; set; }

        [Required, StringLength(5)]
        public string ClavePlanEstudio { get; set; } = string.Empty;

        [Required, StringLength(6)]
        public string PlanEstudioNombre { get; set; } = string.Empty;

        public DateTime? FechaCreacion { get; set; }
        public int TotalCreditos { get; set; }

        public string? PerfilDelIngreso { get; set; }
        public string? PerfilDeEgreso { get; set; }
        public string? CampoOcupacional { get; set; }
        public string? Comentarios { get; set; }

        public bool Estatus { get; set; }

        // Navigation
        public E_Carrera Carreras { get; set; } = null!;
        public ICollection<E_PlanDeMateria> PlanEstudioMaterias { get; set; } = new List<E_PlanDeMateria>();
    }
}
