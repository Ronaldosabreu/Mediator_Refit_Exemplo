using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Application
{
  public class CepInsertCommand : IRequest<int>
  {
    public string Cidade { get; set; }
  }
}
