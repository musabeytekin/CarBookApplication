global using MediatR;
global using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetLocationQuery());
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(CreateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteLocationCommand(id));
            return Ok();
        }
        
    }
}
