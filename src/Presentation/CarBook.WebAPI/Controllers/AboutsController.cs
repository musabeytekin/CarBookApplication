using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    public AboutsController(CreateAboutCommandHandler createAboutCommandHandler,
        DeleteAboutCommandHandler deleteAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler,
        GetAboutQueryHandler getAboutsQueryHandler, UpdateAboutCommandHandler updateAboutCommandHandler)
    {
        _createAboutCommandHandler = createAboutCommandHandler;
        _deleteAboutCommandHandler = deleteAboutCommandHandler;
        _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
        _getAboutsQueryHandler = getAboutsQueryHandler;
        _updateAboutCommandHandler = updateAboutCommandHandler;
    }

    private readonly CreateAboutCommandHandler _createAboutCommandHandler;
    private readonly DeleteAboutCommandHandler _deleteAboutCommandHandler;
    private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
    private readonly GetAboutQueryHandler _getAboutsQueryHandler;
    private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;


    [HttpGet]
    public async Task<IActionResult> GetAboutList()
    {
        var result = await _getAboutsQueryHandler.Handle();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAboutById(int id)
    {
        var result = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
    {
        await _createAboutCommandHandler.Handle(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
    {
        await _updateAboutCommandHandler.Handle(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAbout(int id)
    {
        await _deleteAboutCommandHandler.Handle(new DeleteAboutCommand(id));
        return Ok();
    }
}