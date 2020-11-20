using Louer.Domain.Enums;

namespace Louer.Domain.Entities
{
    public class ClienteTelefone
    {
        public int Id { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public TipoTelefone TipoTelefone { get; set; }
    }
}
