using System.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TareaCursoCore.Models
{
    public enum TipoAfiliado
    {

        
        [Display(Name = "Funcionario/a")]
        Funcionario = 0,
        [Display(Name = "Carga")]
        Carga = 1,
        [Display(Name = "Jubilado/a")]
        Jubilado = 2
    }



    static class Extension
    {
        public static string Nombre(this TipoAfiliado tipoAfiliado)
        {
            return typeof(TipoAfiliado).
                GetField(tipoAfiliado.ToString()).
                GetCustomAttribute<DescriptionAttribute>(false).
                Description;
        }
    }
}
