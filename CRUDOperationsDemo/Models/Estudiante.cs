using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURDOprationsDimo.Models
{
    [Table("Estudiantes", Schema ="HR")]
    public class Estudiante
    {
        [Key]
        [Display(Name="ID")] 
        public int? EstudiantesId { get; set; }

        [Required]
        [Display(Name = "Nombres")]
        [Column(TypeName ="varchar(250)")]
        public string EstudiantesName { get; set; } = string.Empty;


        [Required]
        [Display(Name ="Apellidos")]
        [Column (TypeName = "varchar(250)")]
        public string EstudiantesLastName { get; set; } = string.Empty;

        [Display(Name = "Carrera")]
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; } 

    }
}
