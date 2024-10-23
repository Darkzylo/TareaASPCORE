using Microsoft.EntityFrameworkCore;
using TareaCursoCore.Models;

namespace TareaCursoCore.Data
{
    public class BienestarContext : DbContext
    {
        public BienestarContext(DbContextOptions<BienestarContext> options) : base(options)
        {
        }

        public DbSet<Afiliado> Afiliados { get; set; }
        public DbSet<SolicitudBeneficio> SolicitudBeneficios { get; set; }
       
    }
}
