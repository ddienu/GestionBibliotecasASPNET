using System.Numerics;

namespace GestionBibliotecasASPNET.Models
{
    public class Socios
    {
        public BigInteger IdSocio { get; set; }
        public required string NombreSocio { get; set; }
        public required string Email { get; set; }

        public Socios(BigInteger idSocio, string nombreSocio, string email)
        {
            this.IdSocio = idSocio;
            this.NombreSocio = nombreSocio;
        }
    }
}
