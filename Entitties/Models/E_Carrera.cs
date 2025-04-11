using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_Carrera
    {
        [Key]
        public int IdCarrera { get; set; }

        [Required, StringLength(5)]
        public string ClaveCarrera { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string NombreCarrera { get; set; } = string.Empty;

        [StringLength(50)]
        public string? AliasCarrera { get; set; }

        public bool EstadoCarrera { get; set; }

        [StringLength(50)]
        public string? Estatus { get; set; }

        // Navigation
        public ICollection<E_PlanDeEstudio> PlanesEstudio { get; set; } = new List<E_PlanDeEstudio>();
    }
}
