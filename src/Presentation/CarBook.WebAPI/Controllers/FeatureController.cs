global using MediatR;
global using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Queries.FeatureQueries;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetFeatureQuery());
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(UpdateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteFeatureCommand(id));
            return Ok();
        }
        
    }
}
