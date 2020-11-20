using System.ComponentModel;

namespace Louer.Domain.Enums
{
    public enum TipoCliente
    {
        [Description("Normal")]
        NORMAL,

        [Description("Vip")]
        VIP,

        [Description("Inadimplente")]
        INADIMPLENTE,
    }
}