namespace CarBook.Application.Features.Mediator.Queries.BrandQueries;

public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
{
    public GetBrandByIdQuery(int brandId)
    {
        BrandID = brandId;
    }

    public int BrandID { get; set; }
}