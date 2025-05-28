namespace TiendaServicio.Api.AutorLibro.Model
{
    public class Autor
    {

        public int AutorId { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public DateTime? FechaNacimiento { get; set; }
        public Guid AutorGuid { get; set; }
        public ICollection<Libro> Libros { get; set; } 
        public ICollection<GradoAcademico> Grados { get; set; } 
    }
}
