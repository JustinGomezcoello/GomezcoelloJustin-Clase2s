using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GomezcoelloJustin_Clase2.Models


{
    public class EstudianteUdla
    {
        [Required]
        public string IDBanner {  get; set; }
        [AllowNull]
        //esta anotacion nos dice que correo puede aceptar ninguna entrada
        [EmailAddress]
        public string Correo {  get; set; }
        [MaxLength(100)]

        public string Nombre { get; set; }
        //public List<Carrera> Carreras { get; set; }  listado de carreras cuando son varias
        public Carrera Carrera { get; set; }



    }
}
