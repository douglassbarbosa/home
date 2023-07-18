using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

public class CategoriaClienteContext : DbContext
{
    public CategoriaClienteContext(DbContextOptions<CategoriaClienteContext> options)
        : base(options)
    {
    }

    public DbSet<CategoriaCliente> CategoriaCliente { get; set; } = null!;
}