using System.ComponentModel.DataAnnotations;

namespace GestionBibliotecasASPNET.Models
{
    public class Libros
    {
        public int IdLibro { get; set; }
        [Required (ErrorMessage = "El nombre del libro es obligatorio")]
        public string NombreLibro { get; set; }
		[Required(ErrorMessage = "El autor del libro es obligatorio")]
		public string AutorLibro { get; set; }
		public bool Disponible { get; set; }
        public string? ParteAEditar { get; set; }
        public string? NuevoValor { get; set; }

        public Libros(int idLibro, string nombreLibro, string autorLibro, bool disponible)
        {
            this.IdLibro = idLibro;
            this.NombreLibro = nombreLibro;
            this.AutorLibro = autorLibro;
            this.Disponible = disponible;
        }

        public Libros()
        { 
        }
    }
}
