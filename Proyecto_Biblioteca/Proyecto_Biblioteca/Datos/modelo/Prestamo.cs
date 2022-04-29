using System.ComponentModel.DataAnnotations;

namespace Proyecto_Biblioteca.Datos.modelo
{
    public class Prestamo
    {
        [Key]
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int Fecha { get; set; }
        public int Cantidad  { get; set; }
        public int IdEstudiante { get; set; }
    }
}
