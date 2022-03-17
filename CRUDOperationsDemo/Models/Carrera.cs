using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURDOprationsDimo.Models
{
    [Table("Carrera", Schema ="HR")]
    public class Carrera
    {
        [Key][Display(Name="ID")]
        public int CarreraId { get; set; }

        [Required]
        [Display(Name="Carrera")]
        [Column(TypeName = "varchar(200)")]
        public string CarreraName { get; set; } = string.Empty;
    }
}
