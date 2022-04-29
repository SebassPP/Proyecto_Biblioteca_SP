
using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController:ControllerBase
    {
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "Libro Obtenido";
        }
        public string ObtenerEstudiante()
        {
            return "Estudiante Obtenido";
        }
        public string ObtenerAutor()
        {
            return "Autor Obtenido";
        }
        public string ObtenerPrestamo()
        {
            return "Prestamo Obtenido";
        }
        [HttpPost]
        public string AgregarLibro()
        {
            return "Libro agregado";
        }
        public string AgregarEstudiante()
        {
            return "Estudiante Agregado";
        }
        public string AgregarAutor()
        {
            return "Autor Agregado";
        }
        public string AgregarPrestamo()
        {
            return "Prestamo Agregado";
        }
        [HttpPut]
        public string ActualizarLibro()
        {
            return "Libro Actualizado";
        }
        public string ActualizarEstudiante()
        {
            return "Estudiante Actualizado";
        }
        public string ActualizarAutor()
        {
            return "Autor Actualizado";
        }
        public string ActualizarPrestamo()
        {
            return "Prestamo Actualizado";
        }
        [HttpDelete]
        public string EliminarLibro()
        { 
            return "Libro Eliminado";
        }
        public string EliminarEstudiante()
        {
            return "Estudiante Eliminado";
        }
        public string EliminarAutor()
        {
            return "Autor eliminado";
        }
        public string EliminarPrestamo()
        {
            return "Prestamo Eliminado";
        }
    }
}
