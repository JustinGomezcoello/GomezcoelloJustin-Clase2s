using System.ComponentModel.DataAnnotations;

namespace GomezcoelloJustin_Clase2.Models
{
    public class Carrera
    {
        [Required]
        [Range(1,1000)]
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
