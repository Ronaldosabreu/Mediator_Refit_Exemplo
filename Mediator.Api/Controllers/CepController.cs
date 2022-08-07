using Mediator.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mediator.Api.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class CepController : ControllerBase
  {

    private IMediator _mediator;

    public CepController(IMediator mediator)
    {
      _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromBody] CepCommand filter)
    {
      try 
      {
        return Ok(await _mediator.Send(filter));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpPost]
    public async Task<IActionResult> Post(CepInsertCommand command)
    {
      try
      {
        return Ok(await _mediator.Send(command));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
