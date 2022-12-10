using Microsoft.EntityFrameworkCore;

namespace backend_crud_examen.Models
{
    public class AplicationDbContext:DbContext
    { 
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
             
        }
        public DbSet<Persona> Productos { get; set; } = null!;
    }
}
