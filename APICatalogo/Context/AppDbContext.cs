using APICatalogo.Model;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class AppDbContext : DbContext
{
    //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    //{        
    //}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost,1433;Database=CatalogoDB;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos{ get; set; }
}
