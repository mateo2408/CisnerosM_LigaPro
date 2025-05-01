using CisnerosM_LigaPro.Models;
using Microsoft.EntityFrameworkCore;

namespace CisnerosM_LigaPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
    }
}