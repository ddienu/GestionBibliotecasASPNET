using GestionBibliotecasASPNET.Models;

namespace GestionBibliotecasASPNET.Helpers
{
    public static class GeneradorIDLibro
    {
        public static int GeneradorID(List<Libros> libros)
        {
            int nuevoID = 1;

            if( libros.Any())
            {
                nuevoID = libros.Max(l => l.IdLibro) + 1;
            }

            return nuevoID;
        }
    }
}
