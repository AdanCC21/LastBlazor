using System.ComponentModel.DataAnnotations;

namespace Entitties.Models
{
    public class E_Carrera
    {
        [Key]
        public int idCarrera { get; set; }

        public string? nombre { get; set; }
        public int codigo { get; set; }
    }
}
