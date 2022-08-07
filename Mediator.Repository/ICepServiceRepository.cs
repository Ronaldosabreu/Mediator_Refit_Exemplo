using Mediator.DTOs;
using Refit;
using System;
using System.Threading.Tasks;

namespace Mediator.Repository
{
  public interface ICepServiceRepository
  {
    [Get("/ws/{cep}/json")]
    Task<CepDTO> GetCep(String cep);
  }
}
