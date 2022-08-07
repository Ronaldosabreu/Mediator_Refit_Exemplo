using Mediator.DTOs;
using Mediator.Repository;
using MediatR;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Application
{
  public class CepCommandHandler : IRequestHandler<CepCommand, CepDTO>, ICepServiceRepository
  {

    public async Task<CepDTO> GetCep(string cep)
    {
      var cepClient = RestService.For<ICepServiceRepository>("http://viacep.com.br");
      
      return await cepClient.GetCep(cep);
    }

    public async Task<CepDTO> Handle(CepCommand request, CancellationToken cancellationToken)
    {
      CepDTO cepResponse = await GetCep(request.Cep);
      return cepResponse;
    }
  }
}
