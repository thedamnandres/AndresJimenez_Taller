using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndresJimenez_Taller.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Ciudad { get; set; }

        public int Titulos { get; set; }

        [Required]
        public bool Extranjeros { get; set; }

    }
}
