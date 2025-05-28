namespace TiendaServicio.Api.AutorLibro.Model
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; } 
        public Guid AutorGuid { get; set; }
        public Guid LibroGuid { get; set; } 
        public string Descripcion { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }

    }
}
