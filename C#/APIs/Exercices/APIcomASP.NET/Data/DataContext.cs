using APIcomASP.NET.Models;
using Microsoft.EntityFrameworkCore;


namespace APIcomASP.NET.Data
{
 //Classe comum p/ API com C#
 public class DataContext : DbContext
 {
  //Liberando as funcionalidades de SQL
  public DataContext(DbContextOptions<DataContext> options) : base(options)
  { }

  public DbSet<Contas> conta { get; set; }
 }
}