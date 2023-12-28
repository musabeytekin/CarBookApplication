namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers;

public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
{
    private readonly IRepository<Pricing> _repository;

    public GetPricingQueryHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
    {
        var pricing = await _repository.GetAllAsync();
        return pricing.Select(x => new GetPricingQueryResult
        {
            PricingID = x.PricingID,
            Name = x.Name
        }).ToList();
    }
}