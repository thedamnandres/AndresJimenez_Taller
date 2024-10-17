namespace AndresJimenez_Taller.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion {  get; set; }
        public int Edad {  get; set; }
        public Equipo Equipo { get; set; }

    }
}
