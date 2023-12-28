namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers;

public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
{
    private readonly IRepository<Pricing> _repository;

    public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
    {
        var pricing = await _repository.GetByIdAsync(request.PricingID);
        return new GetPricingByIdQueryResult
        {
            PricingID = pricing.PricingID,
            Name = pricing.Name
        };
    }
}