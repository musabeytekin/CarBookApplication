global using MediatR;
global using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Mediator.Commands.BrandCommands;
using CarBook.Application.Features.Mediator.Queries.BrandQueries;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetBrandQuery());
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetBrandByIdQuery(id));
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(CreateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(UpdateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteBrandCommand(id));
            return Ok();
        }
        
    }
}
