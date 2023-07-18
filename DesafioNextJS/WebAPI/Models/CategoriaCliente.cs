using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;
public class CategoriaCliente
{
    public Guid Id { get; set; }

    [MaxLength(300)] // Adicione a anotação [MaxLength(300)] para limitar o tamanho máximo da propriedade Nome
    public required string Nome { get; set; }
}