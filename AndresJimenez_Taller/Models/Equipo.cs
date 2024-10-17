using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndresJimenez_Taller.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool Extranjeros {  get; set; }
    }
}
