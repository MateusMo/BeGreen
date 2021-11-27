using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Enums
{
    public enum ETipoCadastro
    {
        [Description("Usuário")]
        Usuario = 1,

        [Description("Empresa")]
        Empresa = 2,
    }
}
