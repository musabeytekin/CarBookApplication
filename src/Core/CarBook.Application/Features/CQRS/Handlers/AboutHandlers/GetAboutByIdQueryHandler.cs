using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _repository;
    
    public GetAboutByIdQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var result = await _repository.GetByIdAsync(query.Id);
        return new GetAboutByIdQueryResult()
        {
            AboutID = result.AboutID,
            Title = result.Title,
            Description = result.Description,
            ImageUrl = result.ImageUrl
        };
    }
}