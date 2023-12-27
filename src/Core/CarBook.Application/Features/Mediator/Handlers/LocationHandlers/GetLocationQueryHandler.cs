namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers;

public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
{
    
    private readonly IRepository<Location> _repository;

    public GetLocationQueryHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetLocationQueryResult
        {
            LocationID = x.LocationID,
            Name = x.Name
        }).ToList();
    }
}