namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
{
    private readonly IRepository<Service> _repository;

    public GetServiceQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync();
        return result.Select(x => new GetServiceQueryResult
        {
            ServiceID = x.ServiceID,
            Description = x.Description,
            Title = x.Title,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}