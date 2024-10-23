namespace TareaCursoCore.Models
{
    public class Afiliado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Edad { get; set; }

        public TipoAfiliado TipoAfiliado { get; set; }

    }
}
