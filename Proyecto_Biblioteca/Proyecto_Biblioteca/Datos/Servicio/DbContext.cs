namespace Proyecto_Biblioteca.Datos.Servicio
{
    public class DbContext
    {
        private DbContextOptions<RepositorioBiblioteca> options;

        public DbContext(DbContextOptions<RepositorioBiblioteca> options)
        {
            this.options = options;
        }
    }
}