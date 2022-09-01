using System.ComponentModel.DataAnnotations;

namespace MiPrimerCRUD.Models
{
    public class Asignatura
    {
        [Key]
        public long Id { get; set; }
        public string? Nombre { get; set; }

        //Relacion a otra
        public long? CursilloId { get; set; }
        public Curso? Cursillo { get; set; }    



    }
}
