using System.ComponentModel.DataAnnotations;

namespace APIcomASP.NET.Models
{
 public class Contas
 {
  [Required]
  [Key]
  public int Conta { get; set; }
  public string Nome { get; set; }
  public double Valor { get; set; }
 }
}