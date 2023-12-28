namespace CarBook.Application.Features.Mediator.Queries.PricingQueries;

public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
{
    public GetPricingByIdQuery(int pricingId)
    {
        PricingID = pricingId;
    }

    public int PricingID { get; set; }
}