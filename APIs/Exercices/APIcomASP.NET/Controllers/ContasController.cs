using System.Threading.Tasks;
using APIcomASP.NET.Data;
using APIcomASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace APIcomASP.NET.Controllers
{

 [Controller]
 [Route("api/[controller]")]
 public class ContasController : ControllerBase
 {
  private DataContext cont;

  //Construtor 
  public ContasController(DataContext context)
  {
   this.cont = context;
  }


  [HttpPost("cadastro")]
  public async Task<ActionResult> cadastrar([FromBody] Contas c)
  {
   cont.conta.Add(c);
   await cont.SaveChangesAsync();

   return Created("Objeto conta", c);
  }

  [HttpGet("consulta")]
  public async Task<ActionResult> Lista()
  {
   var contas = await cont.conta.ToListAsync();
   return Ok(contas);
  }

  [HttpGet("{idconta}")]
  public double AcessarConta(int idconta)
  {
   Contas contaEncontrada = cont.conta.Find(idconta);
   double Saldo = contaEncontrada.Valor;
   return Saldo;
  }

  // adicionar valor saldo
  [HttpPut("depositar/{idconta}/{valorCredito}")]
  public async Task<ActionResult> depositar(int idconta, double valorCredito)
  {
   double novoSaldo = valorCredito + AcessarConta(idconta);

   Contas contaParaCreditar = cont.conta.Find(idconta);
   contaParaCreditar.Valor = +novoSaldo;
   cont.conta.Update(contaParaCreditar);
   await cont.SaveChangesAsync();
   return Ok(contaParaCreditar);

  }




  //Teste de API
  [HttpGet("teste")]
  public string oi()
  {
   return "Hello Word";
  }
 }
}