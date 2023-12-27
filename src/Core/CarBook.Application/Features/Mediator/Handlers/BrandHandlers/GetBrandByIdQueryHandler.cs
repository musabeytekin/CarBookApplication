namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers;

public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
{
    private readonly IRepository<Brand> _repository;

    public GetBrandByIdQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BrandID);
        return new GetBrandByIdQueryResult { BrandID = value.BrandID, Name = value.Name };
    }
}