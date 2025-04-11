using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_Materia
    {
        [Key]
        public int IdMateria { get; set; }

        public int IdEstadoCaptura { get; set; }

        [StringLength(6)]
        public string ClaveMateria { get; set; } = string.Empty;

        [StringLength(255)]
        public string NombreMateria { get; set; } = string.Empty;

        public int HC { get; set; }
        public int HL { get; set; }
        public int HT { get; set; }
        public int HPC { get; set; }
        public int HCL { get; set; }
        public int HE { get; set; }
        public int CR { get; set; }

        public string? PropositoGeneral { get; set; }
        public string? Competencia { get; set; }
        public string? Evidencia { get; set; }
        public string? Metodologia { get; set; }
        public string? Criterios { get; set; }
        public string? BibliografiaBasica { get; set; }
        public string? BibliografiaComplementaria { get; set; }
        public string? PerfilDocente { get; set; }
        public string? PathPUA { get; set; }

        public bool EstadoMateria { get; set; }

        // Navigation
        public ICollection<E_PlanDeMateria> PlanEstudioMaterias { get; set; } = new List<E_PlanDeMateria>();
    }
}
