using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BancoDigital.Data;
using BancoDigital.Models;
using BancoDigital.Services;
using BancoDigital.Models.DTO;

namespace BancoDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
       
        private readonly IOperacoesContaService _service;

        public ContasController( IOperacoesContaService service)
        {
            
            _service = service;
        }



        [HttpGet("Saldo/{NumeroConta}")]
        public async Task<ActionResult> Saldo(string conta)
        {

            var existeConta = _service.ContaExistente(conta);

            if (existeConta)
            {
                var saldo = await _service.Saldo(conta);


                return Ok("saldo: " + saldo );
            }
            return BadRequest();
        }


        [HttpPut("Depositar/{NumeroConta}/{valor}")]
        public async Task<ActionResult<Conta>> Depositar([FromBody] EntradaContaDTO conta, float valor)
        {

            var contaAtualizada = await _service.Depositar(conta,valor);
            if (contaAtualizada != null)
            {
                return Ok(contaAtualizada);
            }

            return NotFound();
        }


        [HttpPut("Sacar/{NumeroConta}/{saque}")]
        public async Task<ActionResult<Conta>> Sacar([FromBody] EntradaContaDTO conta, float saque)
        {

            var saldo = await _service.Saldo(conta.Conta);
          
            if (saldo >= saque)
            {

                var contaAtualizada = await _service.Sacar(conta, saque);
                return Ok(contaAtualizada);
            }
            return UnprocessableEntity("Saldo Insuficiente");

            
        }




      



       



       
    }
}
