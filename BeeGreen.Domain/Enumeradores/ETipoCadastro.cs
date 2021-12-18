using System.ComponentModel;

namespace BeGreen.Domain.Enums
{
    public enum ETipoCadastro
    {
        [Description("Usuário")]
        Usuario = 1,

        [Description("Empresa")]
        Empresa = 2,
    }
}
