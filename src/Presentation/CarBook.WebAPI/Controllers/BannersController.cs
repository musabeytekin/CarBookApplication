// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using CarBook.Application.Features.CQRS.Commands.BannerCommands;
// using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
// using CarBook.Application.Features.CQRS.Queries.BannerQueries;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
//
// namespace CarBook.WebAPI.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class BannersController : ControllerBase
//     {
//         private readonly GetBannerQueryHandler _getBannerQueryHandler;
//         private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
//         private readonly CreateBannerCommandHandler _createBannerCommandHandler;
//         private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
//         private readonly DeleteBannerCommandHandler _deleteBannerCommandHandler;
//
//         public BannersController(GetBannerQueryHandler getBannerQueryHandler,
//             GetBannerByIdQueryHandler getBannerByIdQueryHandler, CreateBannerCommandHandler createBannerCommandHandler,
//             UpdateBannerCommandHandler updateBannerCommandHandler,
//             DeleteBannerCommandHandler deleteBannerCommandHandler)
//         {
//             _getBannerQueryHandler = getBannerQueryHandler;
//             _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
//             _createBannerCommandHandler = createBannerCommandHandler;
//             _updateBannerCommandHandler = updateBannerCommandHandler;
//             _deleteBannerCommandHandler = deleteBannerCommandHandler;
//         }
//
//         // GET: api/Banners
//         [HttpGet]
//         public async Task<IActionResult> Get()
//         {
//             var result = await _getBannerQueryHandler.Handle();
//             return Ok(result);
//         }
//
//
//         // GET: api/Banners/5
//         [HttpGet("{id}")]
//         public async Task<IActionResult> Get(int id)
//         {
//             var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
//             return Ok(value);
//         }
//
//         // POST: api/Banners
//         [HttpPost]
//         public async Task<IActionResult> Post([FromBody] CreateBannerCommand command)
//         {
//             await _createBannerCommandHandler.Handle(command);
//             return Ok();
//         }
//
//         // PUT: api/Banners/5
//         [HttpPut]
//         public async Task<IActionResult> Put(UpdateBannerCommand command)
//         {
//             await _updateBannerCommandHandler.Handle(command);
//             return Ok();
//         }
//
//         // DELETE: api/Banners/5
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> Delete(int id)
//         {
//             await _deleteBannerCommandHandler.Handle(new DeleteBannerCommand(id));
//             return Ok();
//         }
//     }
// }