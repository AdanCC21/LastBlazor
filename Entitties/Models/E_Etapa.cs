using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties.Models
{
    public class E_Etapa
    {
        [Key]
        public int IdEtapa { get; set; }

        [StringLength(5)]
        public string ClaveEtapa { get; set; } = string.Empty;

        [StringLength(100)]
        public string NombreEtapa { get; set; } = string.Empty;

        // Navigation
        public ICollection<E_PlanDeMateria> PlanEstudioMaterias { get; set; } = new List<E_PlanDeMateria>();
    }
}
