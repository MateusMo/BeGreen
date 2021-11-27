using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Enums
{
    public enum EGenero
    {
        [Description("Feminino")]
        Feminino = 1,

        [Description("Masculino")]
        Masculino = 2,

        [Description("Outro")]
        Outro = 3
    }
}
