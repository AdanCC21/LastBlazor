using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_AreaDeConocimiento
    {
        [Key]
        public int IdAreaConocimiento { get; set; }

        [StringLength(5)]
        public string ClaveAreaConocimiento { get; set; } = string.Empty;

        [StringLength(50)]
        public string DescripcionAreaConocimiento { get; set; } = string.Empty;

        // Navigation
        public ICollection<E_PlanDeMateria> PlanEstudioMaterias { get; set; } = new List<E_PlanDeMateria>();
    }
}
