using Application.Dtos.Editoriales;

namespace Application.Dtos.Libros
{
    public class LibroDto : LibroFormDto
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }

        public virtual EditorialDto Editorial { get; set; }
    }
}
