using System.ComponentModel.DataAnnotations;

namespace TareaCursoCore.Models
{
    public class SolicitudBeneficio
    {
        public int Id { get; set; }

        public Afiliado? Afiliado { get; set; }

        public int AfiliadoId { get; set; }

        [Range(0, 200000, ErrorMessage = "El monto máximo del beneficio a utilizar es 200.000")]
        public int Monto { get; set; }

        public TipoBeneficio TipoBeneficio { get; set; }

        internal void AgregarBeneficio(Afiliado afiliado, int monto)
        {
            
        }
    }
}
