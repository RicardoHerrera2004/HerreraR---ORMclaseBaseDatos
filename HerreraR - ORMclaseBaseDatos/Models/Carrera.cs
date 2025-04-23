using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerreraR___ORMclaseBaseDatos.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public int FacultadId { get; set; }
        [ForeignKey("FacultadId")]
        public Facultad? Facultad { get; set; }
    }
}
