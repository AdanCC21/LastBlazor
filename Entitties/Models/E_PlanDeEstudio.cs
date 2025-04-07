using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_PlanDeEstudio
    {
        [Key]
        public int idPlanEstudio { get; set; }
        public string? nombre { get; set; }
        public int idCarrera { get; set; }
        public string? nombreCarrera { get; set; }
    }
}
