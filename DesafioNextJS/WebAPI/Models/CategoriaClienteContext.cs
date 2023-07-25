using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class CategoriaClienteContext : DbContext
    {
        public CategoriaClienteContext(DbContextOptions<CategoriaClienteContext> options)
            : base(options)
        {
            if (!CategoriaCliente.Any())
            {
                // Cria uma lista de Categorias pré-carregadas
                List<CategoriaCliente> categorias = new List<CategoriaCliente>
                {
                    new CategoriaCliente { Nome = "Categoria A" },
                    new CategoriaCliente { Nome = "Categoria B" },
                    new CategoriaCliente { Nome = "Categoria C" },
                    new CategoriaCliente { Nome = "Categoria D" },
                    new CategoriaCliente { Nome = "Categoria E" },
                    // Adicione mais categorias conforme necessário
                };

                // Adiciona as categorias no contexto e salva as mudanças no banco de dados
                CategoriaCliente.AddRange(categorias);
                SaveChanges();
            }
        }

        public DbSet<CategoriaCliente> CategoriaCliente { get; set; } = null!;

    }
}
