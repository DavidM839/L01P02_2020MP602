using Microsoft.EntityFrameworkCore;

namespace L01P02_2020MP602.Models
{
    public class BlogDBcontext : DbContext
    {
        public BlogDBcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Publicaciones> publicaciones { get; set; }
        public DbSet<Calificaciones> calificaciones { get; set; }
        public DbSet<Comentarios> comentarios { get; set; }
    }
}
