using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;
public class CategoriaCliente
{
    public Guid Id { get; set; }

    [MaxLength(300)]
    public required string Nome { get; set; }
}