using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MotorBusqueda;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}
