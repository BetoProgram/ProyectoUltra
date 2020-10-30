using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class FacturacionDbContext:DbContext
    {
        public FacturacionDbContext(DbContextOptions<FacturacionDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}