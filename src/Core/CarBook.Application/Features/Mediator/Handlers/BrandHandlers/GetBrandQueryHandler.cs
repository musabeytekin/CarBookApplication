namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers;

public class GetBrandQueryHandler: IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
{
    private readonly IRepository<Brand> _repository;

    public GetBrandQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBrandQueryResult { BrandID = x.BrandID, Name = x.Name }).ToList();
    }
}