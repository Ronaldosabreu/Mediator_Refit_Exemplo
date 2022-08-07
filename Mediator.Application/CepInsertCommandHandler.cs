using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Application
{
  public class CepInsertCommandHandler: IRequestHandler<CepInsertCommand, int>
  {

    public Task<int> Handle(CepInsertCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
