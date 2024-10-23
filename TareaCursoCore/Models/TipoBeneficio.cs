using System.ComponentModel;

namespace TareaCursoCore.Models
{
    public enum TipoBeneficio
    {
        [Description("Medico")]
        Medico = 0,

        [Description("Social")]
        Social = 1,

        [Description("Urgencia")]
        Urgencia = 2
    }
}
