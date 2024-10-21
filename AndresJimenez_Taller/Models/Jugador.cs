using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndresJimenez_Taller.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La posición es obligatoria")]
        public string Posicion { get; set; }

        [Range(0, 100, ErrorMessage = "La edad debe estar entre 0 y 100 años")]
        public int Edad { get; set; }

        public int IdEquipo { get; set; }

        [ForeignKey("IdEquipo")]
        public Equipo Equipo { get; set; }
    }
}
