using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TiendaServicio.Api.AutorLibro.Model;

namespace TiendaServicio.Api.AutorLibro.Persistence
{
    public class ContextoAutorLibro : DbContext

    {
        public ContextoAutorLibro(DbContextOptions<ContextoAutorLibro> options) : base(options) { }
        
            public DbSet<Autor> Autor { get; set; }
            public DbSet<TiendaServicio.Api.AutorLibro.Model.Libro> Libro { get; set; }
            public DbSet<GradoAcademico> Grado { get; set; }
        
    }
}
