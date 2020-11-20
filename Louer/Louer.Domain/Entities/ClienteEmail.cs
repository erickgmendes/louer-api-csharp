using Louer.Domain.Enums;

namespace Louer.Domain.Entities
{
    public class ClienteEmail
    {
        public int Id { get; set; }

        public string Endereco { get; set; }

        public TipoEmail TipoEmail { get; set; }
    }
}
