using Mediator.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Application
{
  public class CepCommand : IRequest<CepDTO>
  {
    public string Cep { get; set; }
  }
}

