using Microsoft.EntityFrameworkCore;
using Library.Entities;
namespace Api1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Organizador> Organizadores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuraciones adicionales del modelo si es necesario
        }
    }
}
