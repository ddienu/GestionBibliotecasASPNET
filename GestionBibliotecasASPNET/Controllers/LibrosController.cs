using GestionBibliotecasASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionBibliotecasASPNET.Controllers
{
    public class LibrosController : Controller
    {

        private static List<Libros> _libros = new List<Libros>
        {
            new Libros(1, "Cien años de soledad", "Gabriel García Márquez", true),
            new Libros(2, "El señor de los anillos", "J.R.R Tolkien", true),
            new Libros(3, "Mi lucha", "Adolf Hitler", true)
        };

        public IActionResult Index()
        {
            return View(_libros);
        }

        public IActionResult AgregarLibros(Libros libro)
        {
            _libros.Add(new Libros(libro.IdLibro, libro.NombreLibro, libro.AutorLibro, libro.Disponible));
            return View();
        }

        public IActionResult QuitarLibros(Libros libro)
        {
            _libros.Remove(libro);
            return View();
        }

        //[HttpPost]
        public IActionResult EditarLibros(Libros libro)
        {
            switch (libro.ParteAEditar)
            {
                case "NombreLibro":
                    libro.NombreLibro = libro.NuevoValor;
                    break;
                case "AutorLibro":
                    libro.AutorLibro = libro.NuevoValor;
                    break;
                case "Disponible":
                    bool disponible;
                    if (bool.TryParse(libro.NuevoValor, out disponible))
                    {
                        libro.Disponible = disponible;
                    }
                    else
                    {
                        TempData["Error"] = "El valor ingresado para Disponible no es válido";
                        return View(libro);
                    }
                    break;
                default:
                    TempData["Error"] = "La opción no es correcta";
                    break;
            }

            return View();
        }
    }
}
