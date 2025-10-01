using Microsoft.EntityFrameworkCore;
using Library.Entities; // o Library.Entities.Entities, según lo que veas

namespace Api1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Organizador> Organizadores { get; set; }
    }
}

}
