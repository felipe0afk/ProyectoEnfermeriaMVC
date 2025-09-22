using Microsoft.EntityFrameworkCore;
using ProyectoEnfermeriaMVC.Models;

namespace ProyectoEnfermeriaMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Testimonio> Testimonios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Testimonio>().HasData(
                new Testimonio { Id = 1, Nombre = "María", Mensaje = "Gracias a la información pude cuidar mejor a mi bebé." },
                new Testimonio { Id = 2, Nombre = "Carlos", Mensaje = "El método canguro nos ayudó muchísimo con nuestro hijo prematuro." },
                new Testimonio { Id = 3, Nombre = "Laura", Mensaje = "Una guía práctica y sencilla que me dio confianza en la lactancia." }
            );
        }
    }
}
