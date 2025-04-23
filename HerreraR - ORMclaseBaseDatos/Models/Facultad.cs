using System.ComponentModel.DataAnnotations;

namespace HerreraR___ORMclaseBaseDatos.Models
{
    public class Facultad
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
