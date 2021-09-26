using BancoDigital.Models;
using BancoDigital.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Services
{
  public interface IOperacoesContaService 
    {

        Task<double> Saldo(string conta);

        Task<Conta> Depositar(EntradaContaDTO conta, float valor);

        Task<Conta> Sacar (EntradaContaDTO conta, float saque);
        bool ContaExistente(string conta);

    }
}
