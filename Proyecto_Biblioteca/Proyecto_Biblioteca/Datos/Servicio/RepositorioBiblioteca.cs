using Microsoft.EntityFrameworkCore;
using Proyecto_Biblioteca.Datos.modelo;

namespace Proyecto_Biblioteca.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {

        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }

    }
}
