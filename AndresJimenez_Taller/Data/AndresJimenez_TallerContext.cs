using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndresJimenez_Taller.Models;

namespace AndresJimenez_Taller.Data
{
    public class AndresJimenez_TallerContext : DbContext
    {
        public AndresJimenez_TallerContext (DbContextOptions<AndresJimenez_TallerContext> options)
            : base(options)
        {
        }

        public DbSet<AndresJimenez_Taller.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<AndresJimenez_Taller.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<AndresJimenez_Taller.Models.Jugador> Jugador { get; set; } = default!;
    }
}
