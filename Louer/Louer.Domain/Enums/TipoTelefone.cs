using System.ComponentModel;

namespace Louer.Domain.Enums
{
    public enum TipoTelefone
    {
        [Description("Residencial")]
        RESIDENCIAL,

        [Description("Celular")]
        CELULAR,

        [Description("Comercial")]
        COMERCIAL,
    }
}
