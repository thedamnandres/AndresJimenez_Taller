using System.ComponentModel.DataAnnotations;

namespace AndresJimenez_Taller.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Direccion { get; set; }
        [MaxLength(50)]
        public string Ciudad { get; set; }

        public int Capacidad { get; set; }

    }
}
