using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_Materia
    {
        [Key]
        public int idMateria { get; set; }
        public string? nombre { get; set; }
        public int creditos { get; set; }
    }
}
