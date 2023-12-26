using CarBook.Application.Features.Mediator.Commands.BannerCommands;
using CarBook.Application.Features.Mediator.Handlers.BannerHandlers;
using CarBook.Application.Features.Mediator.Queries.BannerQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BannersController : ControllerBase
{
    private readonly IMediator _mediator;

    public BannersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetBannerQuery());
        return Ok(result);
    }
        
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetBannerByIdQuery(id));
        return Ok(result);
    }
        
    [HttpPost]
    public async Task<IActionResult> Post(CreateBannerCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
        
    [HttpPut]
    public async Task<IActionResult> Put(UpdateBannerCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
        
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new DeleteBannerCommand(id));
        return Ok();
    }
}