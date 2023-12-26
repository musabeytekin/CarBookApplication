namespace CarBook.Application.Features.Mediator.Handlers.AboutHandlers;

public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
{
    private readonly IRepository<About> _repository;

    public GetAboutQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        
        return values.Select(about => new GetAboutQueryResult
        {
            AboutID = about.AboutID,
            Title = about.Title,
            Description = about.Description,
            ImageUrl = about.ImageUrl
        }).ToList();
    }
}