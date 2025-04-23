using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerreraR___ORMclaseBaseDatos.Models
{
    public class Estudiante
    {
        [Key]
        public string BannerId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneBeca { get; set; }
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; }
    }
}
