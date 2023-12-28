namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
{
    private readonly IRepository<Service> _repository;

    public GetServiceByIdQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(request.ServiceID);
        return new GetServiceByIdQueryResult
        {
            ServiceID = result.ServiceID,
            Description = result.Description,
            Title = result.Title,
            ImageUrl = result.ImageUrl
        };
    }
}