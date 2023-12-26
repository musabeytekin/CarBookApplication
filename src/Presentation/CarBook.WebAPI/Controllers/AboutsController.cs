using CarBook.Application.Features.Mediator.Commands.AboutCommands;
using CarBook.Application.Features.Mediator.Handlers.AboutHandlers;
using CarBook.Application.Features.Mediator.Queries.AboutQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AboutsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAboutQuery());
        return Ok(result);
    }
        
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetAboutByIdQuery(id));
        return Ok(result);
    }
        
    [HttpPost]
    public async Task<IActionResult> Post(CreateAboutCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
        
    [HttpPut]
    public async Task<IActionResult> Put(UpdateAboutCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
        
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new DeleteAboutCommand(id));
        return Ok();
    }
}